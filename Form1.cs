using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Tracking;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualDisplacementMeasurement
{
    public partial class Form1 : Form
    {
        #region Declarations

        private VideoCapture Camera = null;
        private bool IsCapturing = false;
        private Size ImageSize = Size.Empty;

        private bool ScheduleTakeReference = false;
        private Rectangle Roi = Rectangle.Empty;
        private Mat ImgRef = new Mat();
        private Point PointRef = Point.Empty;

        private Tracker MarkerTracker = null;

        private Point MouseStartLocation = Point.Empty;
        private Point MouseEndLocation = Point.Empty;
        private bool IsMouseDown = false;

        private bool IsTuning = false;

        private bool IsTracking { get { return !PointRef.IsEmpty; } }

        #endregion

        public Form1()
        {
            InitializeComponent();
            splitContainer1.Panel2Collapsed = true;
            UpdateInstructionText();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Camera?.Stop();
            Camera?.Dispose();
        }
        private void Clear()
        {
            PointRef = Point.Empty;
            ImgRef = new Mat();
            ImgBoxLive.Image = null;
            ImgBoxRef.Image = null;
            ImgBoxDiff.Image = null;
        }

        private void BtnCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (Camera == null || !Camera.IsOpened)
                {
                    Camera = new VideoCapture();
                    Camera.ImageGrabbed += RetrieveFrame;
                }
                if (!IsCapturing)
                {
                    Clear();
                    Camera.Start();
                    BtnCamera.Text = "Stop Camera";
                    BtnSetRef.Enabled = true;
                    IsCapturing = true;
                }
                else
                {
                    Camera.Stop();
                    BtnCamera.Text = "Start Camera";
                    BtnSetRef.Enabled = false;
                    IsCapturing = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateInstructionText();
        }

        private void BtnSetRef_Click(object sender, EventArgs e)
        {
            if (IsTracking)
            {
                BtnSetRef.Text = "Start Tracking";
                Clear();
            }
            else
            {
                BtnSetRef.Text = "Stop Tracking";
                PointRef = Point.Empty;
                ScheduleTakeReference = true;
            }
            UpdateInstructionText();
        }

        private void CheckBoxTune_CheckedChanged(object sender, EventArgs e)
        {
            IsTuning = CheckBoxTune.Checked;
            splitContainer1.Panel2Collapsed = !IsTuning;
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void BtnResetSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void RetrieveFrame(object sender, EventArgs arg)
        {
            Mat diff = new Mat();
            Point center = Point.Empty;

            // retrieve image from camera
            Mat frame = new Mat();
            Camera.Retrieve(frame);
            ImageSize = frame.Size;

            // generate diff image (before drawing stuff)
            if (!ImgRef.IsEmpty && !IsTuning)
            {
                CvInvoke.AbsDiff(frame, ImgRef, diff);
            }

            if (!IsTracking)
            {
                // find marker
                Rectangle boundingBox;
                if (Roi.IsEmpty)
                {
                    center = FindMarker(frame, out boundingBox);
                }
                else
                {
                    using (Mat crop = new Mat(frame.Clone(), Roi))
                    {
                        center = FindMarker(crop, out boundingBox);
                        if (!center.IsEmpty)
                        {
                            center.X += Roi.X;
                            center.Y += Roi.Y;
                            boundingBox.X += Roi.X;
                            boundingBox.Y += Roi.Y;
                        }
                    }
                }

                // store marker point
                if (ScheduleTakeReference && !center.IsEmpty)
                {
                    ImgRef = frame.Clone();
                    PointRef = center;
                    MarkerTracker = new TrackerCSRT();
                    MarkerTracker.Init(ImgRef, boundingBox);
                    ScheduleTakeReference = false;
                    Invoke(new Action(() => UpdateInstructionText()));
                }

                // draw marker
                if (!center.IsEmpty)
                {
                    CvInvoke.Circle(frame, center, 4, new MCvScalar(0, 140, 255), -1);
                    CvInvoke.Rectangle(frame, boundingBox, new MCvScalar(0, 140, 255), 1);
                }

                // draw ROI
                if (!Roi.IsEmpty)
                {
                    using (Mat dark = new Mat(frame.Rows, frame.Cols, frame.Depth, 3))
                    {
                        dark.SetTo(new MCvScalar(1, 1, 1));
                        CvInvoke.Rectangle(dark, Roi, new MCvScalar(2, 2, 2), -1);
                        CvInvoke.Multiply(frame, dark, frame, 0.5);
                    }
                }

                ImgBoxRef.Image = frame;
            }
            else
            {
                // tracker
                if (MarkerTracker.Update(frame, out Rectangle trackingRect))
                {
                    center = new Point(trackingRect.X + trackingRect.Width / 2, trackingRect.Y + trackingRect.Height / 2);
                    CvInvoke.Circle(frame, center, 4, new MCvScalar(0, 140, 255), -1);
                    CvInvoke.Rectangle(frame, trackingRect, new MCvScalar(0, 140, 255), 1);
                }

                ImgBoxLive.Image = frame;
            }

            // update diff image box
            if (!diff.IsEmpty)
            {
                MCvScalar color = new MCvScalar(0, 140, 255);
                if (!center.IsEmpty)
                    CvInvoke.Circle(diff, center, 4, color, -1);
                if (!PointRef.IsEmpty)
                    CvInvoke.Circle(diff, PointRef, 4, color, -1);
                if (!center.IsEmpty && !PointRef.IsEmpty)
                {
                    string dist = CalcDistance(center, PointRef).ToString("0.0");
                    CvInvoke.ArrowedLine(diff, PointRef, center, color);
                    CvInvoke.PutText(diff, dist, new Point(5, diff.Height - 5), FontFace.HersheyComplexSmall, 1, color);
                }
                ImgBoxDiff.Image = diff;
            }

            // update status text
            Invoke(new Action(() => UpdateStatusText(PointRef, center)));
        }

        private void UpdateStatusText(Point pointRef, Point pointLive)
        {
            string txt = string.Format("Image size: {0}x{1}", ImageSize.Width, ImageSize.Height);
            if (!Roi.IsEmpty)
                txt += string.Format(" | ROI size: {0}x{1}", Roi.Width, Roi.Height);
            if (!PointRef.IsEmpty)
                txt += string.Format(" | Reference marker: {0}/{1}", PointRef.X, PointRef.Y);
            if (!pointLive.IsEmpty)
                txt += string.Format(" | Marker: {0}/{1}", pointLive.X, pointLive.Y);
            if (!pointLive.IsEmpty && !PointRef.IsEmpty)
                txt += string.Format(" | Distance: {0}", CalcDistance(pointLive, pointRef).ToString("0.0"));
            toolStripStatusLabel.Text = txt;
        }

        private void UpdateInstructionText()
        {
            string txt;
            if (IsCapturing)
            {
                if (IsTracking)
                {
                    txt = "3. Tracking...";
                }
                else
                {
                    txt = "2. Drag ROI selection and press \"Start Tracking\"";
                }
            }
            else
            {
                txt = "1. Press \"Start Camera\"";
            }
            LblInstruction.Text = txt;
        }

        private static double CalcDistance(PointF p1, PointF p2)
        {
            if (!p1.IsEmpty && !p2.IsEmpty)
                return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            return 0.0;
        }

        #region Find Marker

        private Point FindMarker(Mat frame, out Rectangle boundingRect)
        {
            boundingRect = Rectangle.Empty;

            if (frame.IsEmpty)
                return Point.Empty;

            Point location = Point.Empty;
            Point frameCenter = new Point(frame.Width / 2, frame.Height / 2);
            double distanceFromFrameCenter = 0.0;

            // convert to gray scale
            Mat gray = new Mat();
            if (frame.NumberOfChannels == 3)
                CvInvoke.CvtColor(frame, gray, ColorConversion.Bgr2Gray);
            else
                gray = frame.Clone();

            // add median blurring
            Mat blured = new Mat();
            int blurSize = (int)Properties.Settings.Default.BlurSize;
            if (blurSize > 0)
            {
                blurSize += (blurSize + 1) % 2;
                CvInvoke.MedianBlur(gray, blured, blurSize);
            }
            else
            {
                blured = gray.Clone();
            }
            gray.Dispose();

            // detect edges
            Mat cannyEdges = new Mat();
            CvInvoke.Canny(blured, cannyEdges, (double)Properties.Settings.Default.CannyThreshold1, (double)Properties.Settings.Default.CannyThreshold2);
            blured.Dispose();

            // find contours
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        // find polygon
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * (double)Properties.Settings.Default.ApproxPolyEpsilon, true);

                        // check minimal size
                        if (CvInvoke.ContourArea(approxContour, false) > 100)
                        {
                            // check if polygon in convex
                            bool isConvex = true;
                            LineSegment2D[] edges = PointCollection.PolyLine(approxContour.ToArray(), true);
                            for (int j = 0; j < edges.Length; j++)
                            {
                                double angle = Math.Abs(edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                if (angle > 170)
                                {
                                    isConvex = false;
                                    break;
                                }
                            }
                            if (isConvex)
                            {
                                // draw marker
                                if (IsTuning)
                                    CvInvoke.Polylines(cannyEdges, approxContour, true, new MCvScalar(255), 2);

                                // compute center point
                                RotatedRect rect = CvInvoke.MinAreaRect(approxContour);
                                Point p = new Point((int)rect.Center.X, (int)rect.Center.Y);

                                // take the nearest marker from the center
                                double d = CalcDistance(frameCenter, p);
                                if (location.IsEmpty || d < distanceFromFrameCenter)
                                {
                                    location = p;
                                    distanceFromFrameCenter = d;
                                    boundingRect = rect.MinAreaRect();
                                }
                            }
                        }
                    }
                }
            }

            // show detection
            if (IsTuning)
                ImgBoxDiff.Image = cannyEdges;
            cannyEdges.Dispose();

            return location;
        }

        #endregion

        #region ROI Selection

        private void ImgBoxRef_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && IsCapturing && !IsTracking)
            {
                IsMouseDown = true;
                MouseStartLocation = TranslateZoomMousePosition(e.Location, ImgBoxRef);
                MouseEndLocation = MouseStartLocation;
                Roi = Rectangle.Empty;
            }
        }

        private void ImgBoxRef_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                MouseEndLocation = TranslateZoomMousePosition(e.Location, ImgBoxRef);
                Roi = GetRectangle(MouseStartLocation, MouseEndLocation, ImageSize);
            }
        }

        private void ImgBoxRef_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                MouseEndLocation = TranslateZoomMousePosition(e.Location, ImgBoxRef);
                Roi = GetRectangle(MouseStartLocation, MouseEndLocation, ImageSize);
                IsMouseDown = false;
            }
        }

        private static Rectangle GetRectangle(Point P1, Point P2, Size maxSize)
        {
            Rectangle rect = Rectangle.Empty;
            rect.X = Math.Min(P1.X, P2.X);
            rect.Y = Math.Min(P1.Y, P2.Y);
            rect.Width = Math.Abs(P1.X - P2.X);
            rect.Height = Math.Abs(P1.Y - P2.Y);
            rect.Intersect(new Rectangle(new Point(0, 0), maxSize));
            if (rect.Width == 0 || rect.Height == 0)
                return Rectangle.Empty;
            return rect;
        }

        private static Point TranslateZoomMousePosition(Point coordinates, PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
                return coordinates;

            int imgWidth = pictureBox.Image.Size.Width;
            int imgHeight = pictureBox.Image.Size.Height;

            if (pictureBox.Width == 0 || pictureBox.Height == 0 || imgWidth == 0 || imgHeight == 0)
                return coordinates;

            float imageAspect = (float)imgWidth / imgHeight;
            float controlAspect = (float)pictureBox.Width / pictureBox.Height;

            float newX = coordinates.X;
            float newY = coordinates.Y;
            if (imageAspect > controlAspect)
            {
                float ratioWidth = (float)imgWidth / pictureBox.Width;
                newX *= ratioWidth;
                float scale = (float)pictureBox.Width / imgWidth;
                float displayHeight = scale * imgHeight;
                float diffHeight = pictureBox.Height - displayHeight;
                diffHeight /= 2;
                newY -= diffHeight;
                newY /= scale;
            }
            else
            {
                float ratioHeight = (float)imgHeight / pictureBox.Height;
                newY *= ratioHeight;
                float scale = (float)pictureBox.Height / imgHeight;
                float displayWidth = scale * imgWidth;
                float diffWidth = pictureBox.Width - displayWidth;
                diffWidth /= 2;
                newX -= diffWidth;
                newX /= scale;
            }
            return new Point((int)newX, (int)newY);
        }

        #endregion
    }
}
