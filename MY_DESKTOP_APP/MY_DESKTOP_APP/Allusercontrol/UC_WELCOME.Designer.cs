namespace MY_DESKTOP_APP.Allusercontrol
{
    partial class UC_WELCOME
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_WELCOME));
            pictureBox1 = new PictureBox();
            labelBanner = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(617, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelBanner
            // 
            labelBanner.AutoSize = true;
            labelBanner.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBanner.Location = new Point(173, 389);
            labelBanner.Name = "labelBanner";
            labelBanner.Size = new Size(400, 54);
            labelBanner.TabIndex = 1;
            labelBanner.Text = "ARINA COMPUTERS";
            labelBanner.Click += labelBanner_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_WELCOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelBanner);
            Controls.Add(pictureBox1);
            Name = "UC_WELCOME";
            Size = new Size(781, 514);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelBanner;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
