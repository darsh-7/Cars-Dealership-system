namespace Project_X
{
    partial class UserControlImg
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
            this.carImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carImg)).BeginInit();
            this.SuspendLayout();
            // 
            // carImg
            // 
            this.carImg.BackColor = System.Drawing.Color.White;
            this.carImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carImg.Location = new System.Drawing.Point(5, 0);
            this.carImg.Name = "carImg";
            this.carImg.Size = new System.Drawing.Size(165, 169);
            this.carImg.TabIndex = 1;
            this.carImg.TabStop = false;
            this.carImg.Tag = "car img";
            // 
            // UserControlImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.carImg);
            this.Name = "UserControlImg";
            this.Size = new System.Drawing.Size(175, 169);
            ((System.ComponentModel.ISupportInitialize)(this.carImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox carImg;
    }
}
