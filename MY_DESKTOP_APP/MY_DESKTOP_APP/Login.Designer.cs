namespace MY_DESKTOP_APP
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnclose = new PictureBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnclose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 656);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(462, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(523, 110);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(350, 285);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(350, 416);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.BorderColor = Color.Blue;
            txtusername.BorderRadius = 15;
            txtusername.CustomizableEdges = customizableEdges1;
            txtusername.DefaultText = "";
            txtusername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtusername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtusername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtusername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtusername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtusername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtusername.Location = new Point(350, 336);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Name = "txtusername";
            txtusername.PasswordChar = '\0';
            txtusername.PlaceholderForeColor = Color.Silver;
            txtusername.PlaceholderText = "Enter Username";
            txtusername.SelectedText = "";
            txtusername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtusername.Size = new Size(508, 47);
            txtusername.TabIndex = 5;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BorderColor = Color.Blue;
            txtpassword.BorderRadius = 15;
            txtpassword.CustomizableEdges = customizableEdges3;
            txtpassword.DefaultText = "";
            txtpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Location = new Point(350, 456);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderForeColor = Color.Silver;
            txtpassword.PlaceholderText = "Enter Password";
            txtpassword.SelectedText = "";
            txtpassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtpassword.Size = new Size(508, 47);
            txtpassword.TabIndex = 6;
            // 
            // btnclose
            // 
            btnclose.Image = (Image)resources.GetObject("btnclose.Image");
            btnclose.Location = new Point(868, 0);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(27, 23);
            btnclose.SizeMode = PictureBoxSizeMode.Zoom;
            btnclose.TabIndex = 9;
            btnclose.TabStop = false;
            btnclose.Click += btnclose_Click;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 20;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(439, 544);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(225, 56);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(462, 614);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 23);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Continue As Guest";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(897, 656);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(btnclose);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnclose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private PictureBox btnclose;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private LinkLabel linkLabel1;
    }
}
