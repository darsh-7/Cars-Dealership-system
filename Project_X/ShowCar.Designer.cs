namespace Project_X
{
    partial class ShowCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCar));
            this.carModel = new System.Windows.Forms.Label();
            this.carcost = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.carYear = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_offer = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nodata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carModel
            // 
            this.carModel.AutoSize = true;
            this.carModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModel.Location = new System.Drawing.Point(98, 17);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(72, 17);
            this.carModel.TabIndex = 2;
            this.carModel.Text = "Car Model";
            // 
            // carcost
            // 
            this.carcost.AutoSize = true;
            this.carcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carcost.Location = new System.Drawing.Point(65, 45);
            this.carcost.Name = "carcost";
            this.carcost.Size = new System.Drawing.Size(40, 17);
            this.carcost.TabIndex = 3;
            this.carcost.Text = "Price";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(323, 12);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "ID";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(272, 420);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 5;
            this.Date.Text = "Date";
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.Color.Black;
            this.Buy.ForeColor = System.Drawing.Color.White;
            this.Buy.Location = new System.Drawing.Point(233, 381);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(108, 36);
            this.Buy.TabIndex = 14;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(290, 365);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(49, 13);
            this.quantity.TabIndex = 8;
            this.quantity.Text = "Quantity ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(18, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Car Model :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(18, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Year :";
            // 
            // carSpeed
            // 
            this.carSpeed.AutoSize = true;
            this.carSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carSpeed.Location = new System.Drawing.Point(72, 90);
            this.carSpeed.Name = "carSpeed";
            this.carSpeed.Size = new System.Drawing.Size(49, 17);
            this.carSpeed.TabIndex = 15;
            this.carSpeed.Text = "Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(18, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Speed :";
            // 
            // carYear
            // 
            this.carYear.AutoSize = true;
            this.carYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carYear.Location = new System.Drawing.Point(72, 115);
            this.carYear.Name = "carYear";
            this.carYear.Size = new System.Drawing.Size(36, 17);
            this.carYear.TabIndex = 17;
            this.carYear.Text = "year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(18, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Color :";
            // 
            // colorlabel
            // 
            this.colorlabel.AutoSize = true;
            this.colorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colorlabel.Location = new System.Drawing.Point(72, 68);
            this.colorlabel.Name = "colorlabel";
            this.colorlabel.Size = new System.Drawing.Size(41, 17);
            this.colorlabel.TabIndex = 18;
            this.colorlabel.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label8.Location = new System.Drawing.Point(19, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Offer :";
            this.label8.Visible = false;
            // 
            // lbl_offer
            // 
            this.lbl_offer.AutoSize = true;
            this.lbl_offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_offer.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lbl_offer.Location = new System.Drawing.Point(66, 138);
            this.lbl_offer.Name = "lbl_offer";
            this.lbl_offer.Size = new System.Drawing.Size(37, 17);
            this.lbl_offer.TabIndex = 23;
            this.lbl_offer.Text = "offer";
            this.lbl_offer.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(347, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(514, 435);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // nodata
            // 
            this.nodata.AutoSize = true;
            this.nodata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nodata.Location = new System.Drawing.Point(264, 45);
            this.nodata.Name = "nodata";
            this.nodata.Size = new System.Drawing.Size(77, 13);
            this.nodata.TabIndex = 26;
            this.nodata.Text = "No Data found";
            this.nodata.Visible = false;
            // 
            // ShowCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 459);
            this.Controls.Add(this.nodata);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_offer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorlabel);
            this.Controls.Add(this.carYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.carSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.carcost);
            this.Controls.Add(this.carModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowCar";
            this.Text = "ShowCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label carModel;
        private System.Windows.Forms.Label carcost;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label carSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label carYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label colorlabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_offer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label nodata;
    }
}