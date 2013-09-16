namespace RaceOfAMadButtons
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.resume_btn = new System.Windows.Forms.Button();
            this.first_btn = new RaceOfAMadButtons.ComparableButton();
            this.second_btn = new RaceOfAMadButtons.ComparableButton();
            this.third_btn = new RaceOfAMadButtons.ComparableButton();
            this.fourth_btn = new RaceOfAMadButtons.ComparableButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFinish = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinish)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.start_btn);
            this.groupBox1.Controls.Add(this.stop_btn);
            this.groupBox1.Controls.Add(this.pause_btn);
            this.groupBox1.Controls.Add(this.resume_btn);
            this.groupBox1.Location = new System.Drawing.Point(311, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control panel";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(11, 35);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(113, 35);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Location = new System.Drawing.Point(215, 35);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(75, 23);
            this.pause_btn.TabIndex = 3;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // resume_btn
            // 
            this.resume_btn.Location = new System.Drawing.Point(317, 35);
            this.resume_btn.Name = "resume_btn";
            this.resume_btn.Size = new System.Drawing.Size(75, 23);
            this.resume_btn.TabIndex = 4;
            this.resume_btn.Text = "Resume";
            this.resume_btn.UseVisualStyleBackColor = true;
            this.resume_btn.Click += new System.EventHandler(this.resume_btn_Click);
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(20, 20);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(75, 23);
            this.first_btn.TabIndex = 10;
            this.first_btn.Text = "button1";
            this.first_btn.UseVisualStyleBackColor = true;
            // 
            // second_btn
            // 
            this.second_btn.Location = new System.Drawing.Point(20, 62);
            this.second_btn.Name = "second_btn";
            this.second_btn.Size = new System.Drawing.Size(75, 23);
            this.second_btn.TabIndex = 10;
            this.second_btn.Text = "button2";
            this.second_btn.UseVisualStyleBackColor = true;
            // 
            // third_btn
            // 
            this.third_btn.Location = new System.Drawing.Point(20, 104);
            this.third_btn.Name = "third_btn";
            this.third_btn.Size = new System.Drawing.Size(75, 23);
            this.third_btn.TabIndex = 10;
            this.third_btn.Text = "button3";
            this.third_btn.UseVisualStyleBackColor = true;
            // 
            // fourth_btn
            // 
            this.fourth_btn.Location = new System.Drawing.Point(20, 146);
            this.fourth_btn.Name = "fourth_btn";
            this.fourth_btn.Size = new System.Drawing.Size(75, 23);
            this.fourth_btn.TabIndex = 10;
            this.fourth_btn.Text = "button4";
            this.fourth_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RaceOfAMadButtons.Properties.Resources.Start;
            this.pictureBox1.Location = new System.Drawing.Point(101, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxFinish
            // 
            this.pictureBoxFinish.Image = global::RaceOfAMadButtons.Properties.Resources.Finish;
            this.pictureBoxFinish.Location = new System.Drawing.Point(968, 3);
            this.pictureBoxFinish.Name = "pictureBoxFinish";
            this.pictureBoxFinish.Size = new System.Drawing.Size(45, 186);
            this.pictureBoxFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFinish.TabIndex = 6;
            this.pictureBoxFinish.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1025, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxFinish);
            this.Controls.Add(this.fourth_btn);
            this.Controls.Add(this.third_btn);
            this.Controls.Add(this.second_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.first_btn);
            this.Name = "MainForm";
            this.Text = "Race of a mad buttons.  (Developed by Doluda S.V.)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button resume_btn;
        
        private ComparableButton first_btn;
        private ComparableButton second_btn;
        private ComparableButton third_btn;
        private ComparableButton fourth_btn;
        
        private System.Windows.Forms.PictureBox pictureBoxFinish;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

