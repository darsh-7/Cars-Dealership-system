namespace Project_X
{
    partial class changePass
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
            this.password = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 65);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.MaxLength = 15;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(162, 20);
            this.password.TabIndex = 17;
            this.password.UseSystemPasswordChar = true;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Black;
            this.change.ForeColor = System.Drawing.Color.White;
            this.change.Location = new System.Drawing.Point(12, 126);
            this.change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(81, 23);
            this.change.TabIndex = 16;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "new Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "username";
            // 
            // changePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 161);
            this.Controls.Add(this.password);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changePass";
            this.Text = "changePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}