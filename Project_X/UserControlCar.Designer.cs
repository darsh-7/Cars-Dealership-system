namespace Project_X
{
    partial class UserControlCar
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_offer = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(174, 3);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(63, 15);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Car Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price :";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(217, 51);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(27, 13);
            this.lbl_price.TabIndex = 14;
            this.lbl_price.Text = "cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "quantity:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(226, 96);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(44, 13);
            this.lbl_quantity.TabIndex = 16;
            this.lbl_quantity.Text = "quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Color :";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(217, 28);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(30, 13);
            this.lbl_color.TabIndex = 18;
            this.lbl_color.Text = "color";
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.Black;
            this.buy.ForeColor = System.Drawing.Color.White;
            this.buy.Location = new System.Drawing.Point(283, 150);
            this.buy.Margin = new System.Windows.Forms.Padding(2);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(81, 23);
            this.buy.TabIndex = 20;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.button48_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(173, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Offer :";
            this.label4.Visible = false;
            // 
            // lbl_offer
            // 
            this.lbl_offer.AutoSize = true;
            this.lbl_offer.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lbl_offer.Location = new System.Drawing.Point(216, 118);
            this.lbl_offer.Name = "lbl_offer";
            this.lbl_offer.Size = new System.Drawing.Size(28, 13);
            this.lbl_offer.TabIndex = 21;
            this.lbl_offer.Text = "offer";
            this.lbl_offer.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "year:";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(209, 74);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(27, 13);
            this.lbl_year.TabIndex = 23;
            this.lbl_year.Text = "yeat";
            // 
            // UserControlCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_offer);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControlCar";
            this.Size = new System.Drawing.Size(366, 175);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.product_control_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_offer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_year;
    }


}

