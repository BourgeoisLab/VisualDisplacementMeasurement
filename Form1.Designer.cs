namespace VisualDisplacementMeasurement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ImgBoxRef = new Emgu.CV.UI.ImageBox();
            this.ImgBoxLive = new Emgu.CV.UI.ImageBox();
            this.ImgBoxDiff = new Emgu.CV.UI.ImageBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSetRef = new System.Windows.Forms.Button();
            this.BtnCamera = new System.Windows.Forms.Button();
            this.CheckBoxTune = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnResetSettings = new System.Windows.Forms.Button();
            this.BtnSaveSettings = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LblInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxDiff)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgBoxRef
            // 
            this.ImgBoxRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgBoxRef.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ImgBoxRef.Location = new System.Drawing.Point(3, 3);
            this.ImgBoxRef.Name = "ImgBoxRef";
            this.ImgBoxRef.Size = new System.Drawing.Size(313, 201);
            this.ImgBoxRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBoxRef.TabIndex = 2;
            this.ImgBoxRef.TabStop = false;
            this.ImgBoxRef.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgBoxRef_MouseDown);
            this.ImgBoxRef.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgBoxRef_MouseMove);
            this.ImgBoxRef.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgBoxRef_MouseUp);
            // 
            // ImgBoxLive
            // 
            this.ImgBoxLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgBoxLive.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ImgBoxLive.Location = new System.Drawing.Point(322, 3);
            this.ImgBoxLive.Name = "ImgBoxLive";
            this.ImgBoxLive.Size = new System.Drawing.Size(314, 201);
            this.ImgBoxLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBoxLive.TabIndex = 2;
            this.ImgBoxLive.TabStop = false;
            // 
            // ImgBoxDiff
            // 
            this.ImgBoxDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgBoxDiff.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ImgBoxDiff.Location = new System.Drawing.Point(642, 3);
            this.ImgBoxDiff.Name = "ImgBoxDiff";
            this.ImgBoxDiff.Size = new System.Drawing.Size(315, 201);
            this.ImgBoxDiff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBoxDiff.TabIndex = 2;
            this.ImgBoxDiff.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.ImgBoxDiff, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImgBoxRef, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImgBoxLive, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 207);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnSetRef
            // 
            this.BtnSetRef.AutoSize = true;
            this.BtnSetRef.Enabled = false;
            this.BtnSetRef.Location = new System.Drawing.Point(108, 13);
            this.BtnSetRef.Name = "BtnSetRef";
            this.BtnSetRef.Size = new System.Drawing.Size(90, 23);
            this.BtnSetRef.TabIndex = 4;
            this.BtnSetRef.Text = "Start Tracking";
            this.BtnSetRef.UseVisualStyleBackColor = true;
            this.BtnSetRef.Click += new System.EventHandler(this.BtnSetRef_Click);
            // 
            // BtnCamera
            // 
            this.BtnCamera.AutoSize = true;
            this.BtnCamera.Location = new System.Drawing.Point(12, 12);
            this.BtnCamera.Name = "BtnCamera";
            this.BtnCamera.Size = new System.Drawing.Size(90, 23);
            this.BtnCamera.TabIndex = 5;
            this.BtnCamera.Text = "Start Camera";
            this.BtnCamera.UseVisualStyleBackColor = true;
            this.BtnCamera.Click += new System.EventHandler(this.BtnCamera_Click);
            // 
            // CheckBoxTune
            // 
            this.CheckBoxTune.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxTune.AutoSize = true;
            this.CheckBoxTune.Location = new System.Drawing.Point(921, 14);
            this.CheckBoxTune.Name = "CheckBoxTune";
            this.CheckBoxTune.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxTune.TabIndex = 8;
            this.CheckBoxTune.Text = "Tune";
            this.CheckBoxTune.UseVisualStyleBackColor = true;
            this.CheckBoxTune.CheckedChanged += new System.EventHandler(this.CheckBoxTune_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(158, 17);
            this.toolStripStatusLabel.Text = "Press \"Start Camera\" to start.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(169, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 80);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canny Edge Detector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Threshold 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Threshold 1";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::VisualDisplacementMeasurement.Properties.Settings.Default, "CannyThreshold2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown2.Location = new System.Drawing.Point(90, 50);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = global::VisualDisplacementMeasurement.Properties.Settings.Default.CannyThreshold2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::VisualDisplacementMeasurement.Properties.Settings.Default, "CannyThreshold1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(90, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = global::VisualDisplacementMeasurement.Properties.Settings.Default.CannyThreshold1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 80);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Median Blurring";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Size";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::VisualDisplacementMeasurement.Properties.Settings.Default, "BlurSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown4.Location = new System.Drawing.Point(90, 24);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown4.TabIndex = 0;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown4.Value = global::VisualDisplacementMeasurement.Properties.Settings.Default.BlurSize;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Location = new System.Drawing.Point(335, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 80);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contour Approximation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Epsilon";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::VisualDisplacementMeasurement.Properties.Settings.Default, "ApproxPolyEpsilon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(90, 24);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown3.TabIndex = 0;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = global::VisualDisplacementMeasurement.Properties.Settings.Default.ApproxPolyEpsilon;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 83);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnResetSettings);
            this.groupBox4.Controls.Add(this.BtnSaveSettings);
            this.groupBox4.Location = new System.Drawing.Point(501, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 80);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // BtnResetSettings
            // 
            this.BtnResetSettings.Location = new System.Drawing.Point(7, 50);
            this.BtnResetSettings.Name = "BtnResetSettings";
            this.BtnResetSettings.Size = new System.Drawing.Size(147, 23);
            this.BtnResetSettings.TabIndex = 13;
            this.BtnResetSettings.Text = "Reset Settings";
            this.BtnResetSettings.UseVisualStyleBackColor = true;
            this.BtnResetSettings.Click += new System.EventHandler(this.BtnResetSettings_Click);
            // 
            // BtnSaveSettings
            // 
            this.BtnSaveSettings.Location = new System.Drawing.Point(7, 20);
            this.BtnSaveSettings.Name = "BtnSaveSettings";
            this.BtnSaveSettings.Size = new System.Drawing.Size(147, 23);
            this.BtnSaveSettings.TabIndex = 14;
            this.BtnSaveSettings.Text = "Save Settings";
            this.BtnSaveSettings.UseVisualStyleBackColor = true;
            this.BtnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 42);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(960, 294);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 14;
            // 
            // LblInstruction
            // 
            this.LblInstruction.AutoSize = true;
            this.LblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstruction.Location = new System.Drawing.Point(204, 17);
            this.LblInstruction.Name = "LblInstruction";
            this.LblInstruction.Size = new System.Drawing.Size(78, 16);
            this.LblInstruction.TabIndex = 15;
            this.LblInstruction.Text = "Instruction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.LblInstruction);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnCamera);
            this.Controls.Add(this.BtnSetRef);
            this.Controls.Add(this.CheckBoxTune);
            this.Name = "Form1";
            this.Text = "Visual Displacement Measurement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxDiff)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ImgBoxRef;
        private Emgu.CV.UI.ImageBox ImgBoxLive;
        private Emgu.CV.UI.ImageBox ImgBoxDiff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnSetRef;
        private System.Windows.Forms.Button BtnCamera;
        private System.Windows.Forms.CheckBox CheckBoxTune;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnResetSettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnSaveSettings;
        private System.Windows.Forms.Label LblInstruction;
    }
}

