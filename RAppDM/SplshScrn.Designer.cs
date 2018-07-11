namespace RAppDM
{
    partial class SplshScrn
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
            this.statusPBAR = new System.Windows.Forms.ProgressBar();
            this.verTXT = new System.Windows.Forms.Label();
            this.statusTXT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // statusPBAR
            // 
            this.statusPBAR.Enabled = false;
            this.statusPBAR.Location = new System.Drawing.Point(16, 438);
            this.statusPBAR.MarqueeAnimationSpeed = 5;
            this.statusPBAR.Name = "statusPBAR";
            this.statusPBAR.Size = new System.Drawing.Size(822, 26);
            this.statusPBAR.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.statusPBAR.TabIndex = 0;
            this.statusPBAR.Value = 5;
            // 
            // verTXT
            // 
            this.verTXT.AutoSize = true;
            this.verTXT.BackColor = System.Drawing.Color.Transparent;
            this.verTXT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.verTXT.Location = new System.Drawing.Point(1, 462);
            this.verTXT.Name = "verTXT";
            this.verTXT.Size = new System.Drawing.Size(53, 22);
            this.verTXT.TabIndex = 2;
            this.verTXT.Text = "[v0.22a]";
            this.verTXT.UseCompatibleTextRendering = true;
            // 
            // statusTXT
            // 
            this.statusTXT.BackColor = System.Drawing.Color.Transparent;
            this.statusTXT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.statusTXT.Location = new System.Drawing.Point(16, 402);
            this.statusTXT.Name = "statusTXT";
            this.statusTXT.Size = new System.Drawing.Size(822, 35);
            this.statusTXT.TabIndex = 3;
            this.statusTXT.Text = "preparing start!";
            this.statusTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 250;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 350;
            this.timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 150;
            this.timer5.Tick += new System.EventHandler(this.Timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.Timer6_Tick);
            // 
            // SplshScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RAppDM.Properties.Resources.RAppDMsplash4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.ControlBox = false;
            this.Controls.Add(this.statusTXT);
            this.Controls.Add(this.statusPBAR);
            this.Controls.Add(this.verTXT);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SplshScrn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAppDM SplashScreen! this is kinda an easter egg..";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplshScrn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar statusPBAR;
        private System.Windows.Forms.Label verTXT;
        private System.Windows.Forms.Label statusTXT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}

