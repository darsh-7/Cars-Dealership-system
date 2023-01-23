using System.Windows.Forms;

namespace Project_X
{
    partial class Buy_Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy_Car));
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.buy = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emaiBbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selar = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check out";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(4, 55);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.MaxLength = 30;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(212, 20);
            this.nameBox.TabIndex = 20;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.Location = new System.Drawing.Point(1, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "National ID *";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(4, 99);
            this.IDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDBox.MaxLength = 14;
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(212, 20);
            this.IDBox.TabIndex = 22;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(4, 143);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneBox.MaxLength = 11;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(212, 20);
            this.phoneBox.TabIndex = 24;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(4, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(212, 59);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender *";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(4, 36);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(75, 24);
            this.radioFemale.TabIndex = 28;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(4, 17);
            this.radioMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 24);
            this.radioMale.TabIndex = 27;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // buy
            // 
            this.buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buy.BackColor = System.Drawing.Color.Black;
            this.buy.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.buy.ForeColor = System.Drawing.Color.White;
            this.buy.Location = new System.Drawing.Point(256, 372);
            this.buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(83, 26);
            this.buy.TabIndex = 27;
            this.buy.Text = "Submit Order";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 402);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F);
            this.label5.Location = new System.Drawing.Point(2, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label6.Location = new System.Drawing.Point(1, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Customer Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(1, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Phone *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(3, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // emaiBbox
            // 
            this.emaiBbox.Location = new System.Drawing.Point(4, 231);
            this.emaiBbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emaiBbox.MaxLength = 25;
            this.emaiBbox.Name = "emaiBbox";
            this.emaiBbox.Size = new System.Drawing.Size(212, 20);
            this.emaiBbox.TabIndex = 32;
            this.emaiBbox.TextChanged += new System.EventHandler(this.emaiBbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.Location = new System.Drawing.Point(108, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Selar :";
            // 
            // selar
            // 
            this.selar.AutoSize = true;
            this.selar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.selar.Location = new System.Drawing.Point(154, 6);
            this.selar.Name = "selar";
            this.selar.Size = new System.Drawing.Size(40, 20);
            this.selar.TabIndex = 35;
            this.selar.Text = "Selar";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F);
            this.datelabel.Location = new System.Drawing.Point(55, 333);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(39, 17);
            this.datelabel.TabIndex = 36;
            this.datelabel.Text = "Date";
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closebutton.BackColor = System.Drawing.Color.Black;
            this.closebutton.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.closebutton.ForeColor = System.Drawing.Color.White;
            this.closebutton.Location = new System.Drawing.Point(256, 402);
            this.closebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(83, 26);
            this.closebutton.TabIndex = 37;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label8.Location = new System.Drawing.Point(4, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Address";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(4, 187);
            this.addressBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressBox.MaxLength = 30;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(212, 20);
            this.addressBox.TabIndex = 38;
            this.addressBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Buy_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 439);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.selar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emaiBbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Buy_Car";
            this.Text = "Motor Empire";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private Label label3;
        private TextBox IDBox;
        private TextBox phoneBox;
        private GroupBox groupBox1;
        private RadioButton radioFemale;
        private RadioButton radioMale;
        private Button buy;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label4;
        private TextBox emaiBbox;
        private Label label7;
        private Label selar;
        private Label datelabel;
        private Button closebutton;
        private Label label8;
        private TextBox addressBox;
    }
}