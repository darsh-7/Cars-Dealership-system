using Project_X.Properties;
using System.Windows.Forms;

namespace Project_X
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.use = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.stats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(-15, -58);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(275, 441);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(357, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Motor Empire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(322, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(325, 153);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.MaxLength = 15;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(162, 20);
            this.username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(322, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // use
            // 
            this.use.BackColor = System.Drawing.Color.Black;
            this.use.ForeColor = System.Drawing.Color.White;
            this.use.Location = new System.Drawing.Point(322, 250);
            this.use.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(81, 23);
            this.use.TabIndex = 7;
            this.use.Text = "Sign in";
            this.use.UseVisualStyleBackColor = false;
            this.use.Click += new System.EventHandler(this.login_Click);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.login.BackColor = System.Drawing.Color.Firebrick;
            this.login.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(472, 328);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(54, 18);
            this.login.TabIndex = 10;
            this.login.Text = "Exit";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.exit_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(325, 194);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.MaxLength = 15;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(162, 20);
            this.password.TabIndex = 11;
            this.password.UseSystemPasswordChar = true;
            // 
            // stats
            // 
            this.stats.AutoSize = true;
            this.stats.Font = new System.Drawing.Font("Yu Gothic Medium", 9F);
            this.stats.ForeColor = System.Drawing.Color.IndianRed;
            this.stats.Location = new System.Drawing.Point(322, 216);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(33, 16);
            this.stats.TabIndex = 12;
            this.stats.Text = "Erorr";
            this.stats.Visible = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 354);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.use);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Label label5;
        private Label label1;
        private TextBox username;
        private Label label2;
        private Button use;
        private Button login;
        private TextBox password;
        private Label stats;
    }
}

