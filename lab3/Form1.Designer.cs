namespace lab3
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
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.panelColor = new System.Windows.Forms.Panel();
            this.trackBar12 = new System.Windows.Forms.TrackBar();
            this.trackBar21 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar21)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRed
            // 
            this.trackBarRed.LargeChange = 1;
            this.trackBarRed.Location = new System.Drawing.Point(128, 54);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(428, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.LargeChange = 1;
            this.trackBarGreen.Location = new System.Drawing.Point(128, 106);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(428, 45);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.LargeChange = 1;
            this.trackBarBlue.Location = new System.Drawing.Point(128, 157);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(428, 45);
            this.trackBarBlue.TabIndex = 2;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(142, 201);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(414, 237);
            this.panelColor.TabIndex = 3;
            // 
            // trackBar12
            // 
            this.trackBar12.LargeChange = 1;
            this.trackBar12.Location = new System.Drawing.Point(142, 461);
            this.trackBar12.Maximum = 255;
            this.trackBar12.Name = "trackBar12";
            this.trackBar12.Size = new System.Drawing.Size(428, 45);
            this.trackBar12.TabIndex = 4;
            this.trackBar12.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBar21
            // 
            this.trackBar21.LargeChange = 1;
            this.trackBar21.Location = new System.Drawing.Point(142, 512);
            this.trackBar21.Maximum = 255;
            this.trackBar21.Name = "trackBar21";
            this.trackBar21.Size = new System.Drawing.Size(428, 45);
            this.trackBar21.TabIndex = 5;
            this.trackBar21.Scroll += new System.EventHandler(this.trackBar21_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 688);
            this.Controls.Add(this.trackBar21);
            this.Controls.Add(this.trackBar12);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar12)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TrackBar trackBar12;
        private System.Windows.Forms.TrackBar trackBar21;

        #endregion

        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Panel panelColor;
    }
}