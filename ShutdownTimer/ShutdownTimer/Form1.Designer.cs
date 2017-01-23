namespace ShutdownTimer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hour = new System.Windows.Forms.TextBox();
            this.minute = new System.Windows.Forms.TextBox();
            this.Abbrechen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.ComboBox();
            this.inum = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.BrightnessTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::ShutdownTimer.Properties.Resources.indigo_cyan333;
            this.label1.Location = new System.Drawing.Point(285, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(10, 59);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(88, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(252, 12);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(39, 26);
            this.hour.TabIndex = 4;
            this.hour.Text = "0";
            this.hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minute
            // 
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Location = new System.Drawing.Point(297, 12);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(40, 26);
            this.minute.TabIndex = 5;
            this.minute.Text = "0";
            this.minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Abbrechen
            // 
            this.Abbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abbrechen.Location = new System.Drawing.Point(104, 59);
            this.Abbrechen.Name = "Abbrechen";
            this.Abbrechen.Size = new System.Drawing.Size(97, 23);
            this.Abbrechen.TabIndex = 6;
            this.Abbrechen.Text = "Abbrechen";
            this.Abbrechen.UseVisualStyleBackColor = true;
            this.Abbrechen.Click += new System.EventHandler(this.Abbrechen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::ShutdownTimer.Properties.Resources.indigo_cyan;
            this.label2.Location = new System.Drawing.Point(336, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 7);
            this.label2.TabIndex = 8;
            this.label2.Text = "by m00ny";
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.SystemColors.Window;
            this.mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "Runterfahren",
            "Neustarten",
            "Ausloggen"});
            this.mode.Location = new System.Drawing.Point(10, 12);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(144, 28);
            this.mode.TabIndex = 9;
            this.mode.Text = "Runterfahren";
            this.mode.SelectedIndexChanged += new System.EventHandler(this.mode_SelectedIndexChanged);
            // 
            // inum
            // 
            this.inum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inum.FormattingEnabled = true;
            this.inum.Items.AddRange(new object[] {
            "in",
            "um"});
            this.inum.Location = new System.Drawing.Point(160, 12);
            this.inum.Name = "inum";
            this.inum.Size = new System.Drawing.Size(61, 28);
            this.inum.TabIndex = 10;
            this.inum.Text = "in";
            this.inum.SelectedIndexChanged += new System.EventHandler(this.inum_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(287, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Mehr";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.trackBarBrightness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarBrightness.Location = new System.Drawing.Point(0, 48);
            this.trackBarBrightness.Maximum = 90;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(372, 45);
            this.trackBarBrightness.TabIndex = 12;
            this.trackBarBrightness.Tag = "";
            this.trackBarBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // BrightnessTotalLabel
            // 
            this.BrightnessTotalLabel.AutoSize = true;
            this.BrightnessTotalLabel.Location = new System.Drawing.Point(9, 99);
            this.BrightnessTotalLabel.Name = "BrightnessTotalLabel";
            this.BrightnessTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.BrightnessTotalLabel.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ShutdownTimer.Properties.Resources.indigo_cyan31;
            this.ClientSize = new System.Drawing.Size(372, 93);
            this.Controls.Add(this.BrightnessTotalLabel);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.inum);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Abbrechen);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 207);
            this.MinimumSize = new System.Drawing.Size(388, 132);
            this.Name = "MainWindow";
            this.Text = "Shutdown Timer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.Button Abbrechen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.ComboBox inum;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label BrightnessTotalLabel;
    }
}

