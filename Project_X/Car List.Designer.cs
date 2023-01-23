using System.Windows.Forms;

namespace Project_X
{
    partial class Car_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_list));
            this.logout = new System.Windows.Forms.Button();
            this.User_Name = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inStockButton = new System.Windows.Forms.Button();
            this.offersButton = new System.Windows.Forms.Button();
            this.outStockButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.applyYearBox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearBox2 = new System.Windows.Forms.TextBox();
            this.yearBox1 = new System.Windows.Forms.TextBox();
            this.oldest = new System.Windows.Forms.Button();
            this.newest = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.applyPriceBox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceBox2 = new System.Windows.Forms.TextBox();
            this.lowerprice = new System.Windows.Forms.Button();
            this.priceBox1 = new System.Windows.Forms.TextBox();
            this.higherprice = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.closeapp = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.NoData = new System.Windows.Forms.Label();
            this.bills = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sublayer = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout.BackColor = System.Drawing.Color.Black;
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(9, 830);
            this.logout.Margin = new System.Windows.Forms.Padding(2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(81, 23);
            this.logout.TabIndex = 8;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.User_Name.Location = new System.Drawing.Point(11, 9);
            this.User_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(87, 21);
            this.User_Name.TabIndex = 10;
            this.User_Name.Text = "Welcome ";
            // 
            // panel9
            // 
            this.panel9.AllowDrop = true;
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel9.AutoScroll = true;
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BackColor = System.Drawing.Color.Linen;
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.searchbutton);
            this.panel9.Controls.Add(this.reset);
            this.panel9.Controls.Add(this.searchBox);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(9, 43);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(337, 783);
            this.panel9.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.inStockButton);
            this.panel1.Controls.Add(this.offersButton);
            this.panel1.Controls.Add(this.outStockButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(16, 460);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 184);
            this.panel1.TabIndex = 23;
            // 
            // inStockButton
            // 
            this.inStockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inStockButton.BackColor = System.Drawing.Color.Black;
            this.inStockButton.ForeColor = System.Drawing.Color.White;
            this.inStockButton.Location = new System.Drawing.Point(11, 57);
            this.inStockButton.Margin = new System.Windows.Forms.Padding(2);
            this.inStockButton.Name = "inStockButton";
            this.inStockButton.Size = new System.Drawing.Size(81, 23);
            this.inStockButton.TabIndex = 26;
            this.inStockButton.Text = "In Stock";
            this.inStockButton.UseVisualStyleBackColor = false;
            this.inStockButton.Click += new System.EventHandler(this.inStokeButton_Click);
            // 
            // offersButton
            // 
            this.offersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.offersButton.BackColor = System.Drawing.Color.Black;
            this.offersButton.ForeColor = System.Drawing.Color.White;
            this.offersButton.Location = new System.Drawing.Point(11, 84);
            this.offersButton.Margin = new System.Windows.Forms.Padding(2);
            this.offersButton.Name = "offersButton";
            this.offersButton.Size = new System.Drawing.Size(81, 23);
            this.offersButton.TabIndex = 20;
            this.offersButton.Text = "Offers";
            this.offersButton.UseVisualStyleBackColor = false;
            this.offersButton.Click += new System.EventHandler(this.offersButton_Click);
            // 
            // outStockButton
            // 
            this.outStockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outStockButton.BackColor = System.Drawing.Color.Black;
            this.outStockButton.ForeColor = System.Drawing.Color.White;
            this.outStockButton.Location = new System.Drawing.Point(141, 57);
            this.outStockButton.Margin = new System.Windows.Forms.Padding(2);
            this.outStockButton.Name = "outStockButton";
            this.outStockButton.Size = new System.Drawing.Size(81, 23);
            this.outStockButton.TabIndex = 19;
            this.outStockButton.Text = "Out Stock";
            this.outStockButton.UseVisualStyleBackColor = false;
            this.outStockButton.Click += new System.EventHandler(this.outStokeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Model (year)";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel11.Controls.Add(this.applyYearBox);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.yearBox2);
            this.panel11.Controls.Add(this.yearBox1);
            this.panel11.Controls.Add(this.oldest);
            this.panel11.Controls.Add(this.newest);
            this.panel11.Controls.Add(this.label26);
            this.panel11.Location = new System.Drawing.Point(16, 262);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(234, 184);
            this.panel11.TabIndex = 22;
            // 
            // applyYearBox
            // 
            this.applyYearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyYearBox.BackColor = System.Drawing.Color.Black;
            this.applyYearBox.ForeColor = System.Drawing.Color.White;
            this.applyYearBox.Location = new System.Drawing.Point(141, 100);
            this.applyYearBox.Margin = new System.Windows.Forms.Padding(2);
            this.applyYearBox.Name = "applyYearBox";
            this.applyYearBox.Size = new System.Drawing.Size(81, 23);
            this.applyYearBox.TabIndex = 26;
            this.applyYearBox.Text = "Apply";
            this.applyYearBox.UseVisualStyleBackColor = false;
            this.applyYearBox.Click += new System.EventHandler(this.applyYearBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "From";
            // 
            // yearBox2
            // 
            this.yearBox2.Location = new System.Drawing.Point(50, 69);
            this.yearBox2.Margin = new System.Windows.Forms.Padding(2);
            this.yearBox2.MaxLength = 4;
            this.yearBox2.Name = "yearBox2";
            this.yearBox2.Size = new System.Drawing.Size(172, 20);
            this.yearBox2.TabIndex = 29;
            this.yearBox2.TextChanged += new System.EventHandler(this.yearBox2_TextChanged);
            // 
            // yearBox1
            // 
            this.yearBox1.Location = new System.Drawing.Point(50, 32);
            this.yearBox1.Margin = new System.Windows.Forms.Padding(2);
            this.yearBox1.MaxLength = 4;
            this.yearBox1.Name = "yearBox1";
            this.yearBox1.Size = new System.Drawing.Size(172, 20);
            this.yearBox1.TabIndex = 28;
            this.yearBox1.TextChanged += new System.EventHandler(this.yearBox2_TextChanged);
            // 
            // oldest
            // 
            this.oldest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.oldest.BackColor = System.Drawing.Color.Black;
            this.oldest.ForeColor = System.Drawing.Color.White;
            this.oldest.Location = new System.Drawing.Point(11, 154);
            this.oldest.Margin = new System.Windows.Forms.Padding(2);
            this.oldest.Name = "oldest";
            this.oldest.Size = new System.Drawing.Size(81, 23);
            this.oldest.TabIndex = 20;
            this.oldest.Text = "Oldest";
            this.oldest.UseVisualStyleBackColor = false;
            this.oldest.Click += new System.EventHandler(this.oldest_Click);
            // 
            // newest
            // 
            this.newest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newest.BackColor = System.Drawing.Color.Black;
            this.newest.ForeColor = System.Drawing.Color.White;
            this.newest.Location = new System.Drawing.Point(10, 127);
            this.newest.Margin = new System.Windows.Forms.Padding(2);
            this.newest.Name = "newest";
            this.newest.Size = new System.Drawing.Size(81, 23);
            this.newest.TabIndex = 19;
            this.newest.Text = "Newest";
            this.newest.UseVisualStyleBackColor = false;
            this.newest.Click += new System.EventHandler(this.newest_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label26.Location = new System.Drawing.Point(9, 10);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(98, 19);
            this.label26.TabIndex = 10;
            this.label26.Text = "Model (year)";
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Black;
            this.searchbutton.ForeColor = System.Drawing.Color.White;
            this.searchbutton.Location = new System.Drawing.Point(254, 10);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(81, 23);
            this.searchbutton.TabIndex = 20;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.BackColor = System.Drawing.Color.Black;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(254, 758);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(81, 23);
            this.reset.TabIndex = 19;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(16, 12);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(234, 20);
            this.searchBox.TabIndex = 19;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel10.Controls.Add(this.applyPriceBox);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.priceBox2);
            this.panel10.Controls.Add(this.lowerprice);
            this.panel10.Controls.Add(this.priceBox1);
            this.panel10.Controls.Add(this.higherprice);
            this.panel10.Controls.Add(this.label27);
            this.panel10.Location = new System.Drawing.Point(16, 50);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(234, 197);
            this.panel10.TabIndex = 21;
            // 
            // applyPriceBox
            // 
            this.applyPriceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyPriceBox.BackColor = System.Drawing.Color.Black;
            this.applyPriceBox.ForeColor = System.Drawing.Color.White;
            this.applyPriceBox.Location = new System.Drawing.Point(141, 106);
            this.applyPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.applyPriceBox.Name = "applyPriceBox";
            this.applyPriceBox.Size = new System.Drawing.Size(81, 23);
            this.applyPriceBox.TabIndex = 23;
            this.applyPriceBox.Text = "Apply";
            this.applyPriceBox.UseVisualStyleBackColor = false;
            this.applyPriceBox.Click += new System.EventHandler(this.applyPriceBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "From";
            // 
            // priceBox2
            // 
            this.priceBox2.Location = new System.Drawing.Point(50, 82);
            this.priceBox2.Margin = new System.Windows.Forms.Padding(2);
            this.priceBox2.Name = "priceBox2";
            this.priceBox2.Size = new System.Drawing.Size(172, 20);
            this.priceBox2.TabIndex = 24;
            // 
            // lowerprice
            // 
            this.lowerprice.BackColor = System.Drawing.Color.Black;
            this.lowerprice.ForeColor = System.Drawing.Color.White;
            this.lowerprice.Location = new System.Drawing.Point(12, 161);
            this.lowerprice.Margin = new System.Windows.Forms.Padding(2);
            this.lowerprice.Name = "lowerprice";
            this.lowerprice.Size = new System.Drawing.Size(81, 23);
            this.lowerprice.TabIndex = 20;
            this.lowerprice.Text = "Low to High";
            this.lowerprice.UseVisualStyleBackColor = false;
            this.lowerprice.Click += new System.EventHandler(this.lowerprice_Click);
            // 
            // priceBox1
            // 
            this.priceBox1.Location = new System.Drawing.Point(50, 44);
            this.priceBox1.Margin = new System.Windows.Forms.Padding(2);
            this.priceBox1.Name = "priceBox1";
            this.priceBox1.Size = new System.Drawing.Size(172, 20);
            this.priceBox1.TabIndex = 23;
            this.priceBox1.TextChanged += new System.EventHandler(this.priceBox1_TextChanged);
            // 
            // higherprice
            // 
            this.higherprice.BackColor = System.Drawing.Color.Black;
            this.higherprice.ForeColor = System.Drawing.Color.White;
            this.higherprice.Location = new System.Drawing.Point(11, 134);
            this.higherprice.Margin = new System.Windows.Forms.Padding(2);
            this.higherprice.Name = "higherprice";
            this.higherprice.Size = new System.Drawing.Size(81, 23);
            this.higherprice.TabIndex = 19;
            this.higherprice.Text = "High to Low";
            this.higherprice.UseVisualStyleBackColor = false;
            this.higherprice.Click += new System.EventHandler(this.higherprice_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label27.Location = new System.Drawing.Point(9, 10);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 19);
            this.label27.TabIndex = 10;
            this.label27.Text = "PRICE (EGP)";
            // 
            // closeapp
            // 
            this.closeapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeapp.BackColor = System.Drawing.Color.Brown;
            this.closeapp.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.closeapp.ForeColor = System.Drawing.Color.White;
            this.closeapp.Location = new System.Drawing.Point(1074, 3);
            this.closeapp.Margin = new System.Windows.Forms.Padding(2);
            this.closeapp.Name = "closeapp";
            this.closeapp.Size = new System.Drawing.Size(60, 21);
            this.closeapp.TabIndex = 18;
            this.closeapp.Text = "Exit";
            this.closeapp.UseVisualStyleBackColor = false;
            this.closeapp.Click += new System.EventHandler(this.closeapp_Click_1);
            // 
            // admin
            // 
            this.admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.admin.BackColor = System.Drawing.Color.Black;
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(263, 830);
            this.admin.Margin = new System.Windows.Forms.Padding(2);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(81, 23);
            this.admin.TabIndex = 19;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Visible = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // NoData
            // 
            this.NoData.AutoSize = true;
            this.NoData.BackColor = System.Drawing.Color.White;
            this.NoData.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NoData.ForeColor = System.Drawing.Color.Red;
            this.NoData.Location = new System.Drawing.Point(346, 23);
            this.NoData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoData.Name = "NoData";
            this.NoData.Size = new System.Drawing.Size(96, 17);
            this.NoData.TabIndex = 20;
            this.NoData.Text = "No Valud Data";
            // 
            // bills
            // 
            this.bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bills.BackColor = System.Drawing.Color.Black;
            this.bills.ForeColor = System.Drawing.Color.White;
            this.bills.Location = new System.Drawing.Point(178, 830);
            this.bills.Margin = new System.Windows.Forms.Padding(2);
            this.bills.Name = "bills";
            this.bills.Size = new System.Drawing.Size(81, 23);
            this.bills.TabIndex = 21;
            this.bills.Text = "Bills";
            this.bills.UseVisualStyleBackColor = false;
            this.bills.Visible = false;
            this.bills.Click += new System.EventHandler(this.bills_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(349, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(785, 810);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // sublayer
            // 
            this.sublayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sublayer.BackColor = System.Drawing.Color.Black;
            this.sublayer.ForeColor = System.Drawing.Color.White;
            this.sublayer.Location = new System.Drawing.Point(94, 830);
            this.sublayer.Margin = new System.Windows.Forms.Padding(2);
            this.sublayer.Name = "sublayer";
            this.sublayer.Size = new System.Drawing.Size(81, 23);
            this.sublayer.TabIndex = 22;
            this.sublayer.Text = "Supplies";
            this.sublayer.UseVisualStyleBackColor = false;
            this.sublayer.Visible = false;
            this.sublayer.Click += new System.EventHandler(this.sublayer_Click);
            // 
            // manageButton
            // 
            this.manageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageButton.BackColor = System.Drawing.Color.Black;
            this.manageButton.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.manageButton.ForeColor = System.Drawing.Color.White;
            this.manageButton.Location = new System.Drawing.Point(1010, 3);
            this.manageButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(60, 21);
            this.manageButton.TabIndex = 23;
            this.manageButton.Text = "Manage";
            this.manageButton.UseVisualStyleBackColor = false;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // Car_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 864);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.sublayer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bills);
            this.Controls.Add(this.NoData);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.closeapp);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Car_list";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button logout;
        private Label User_Name;
        private Panel panel9;
        private Button closeapp;
        private Panel panel11;
        private Button oldest;
        private Button newest;
        private Label label26;
        private Button searchbutton;
        private Button reset;
        private TextBox searchBox;
        private Panel panel10;
        private Button lowerprice;
        private Button higherprice;
        private Label label27;
        private Button admin;
        private Label NoData;
        private Button applyYearBox;
        private Label label3;
        private Label label4;
        private TextBox yearBox2;
        private TextBox yearBox1;
        private Button applyPriceBox;
        private Label label2;
        private Label label1;
        private TextBox priceBox2;
        private TextBox priceBox1;
        private Button bills;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button sublayer;
        private Panel panel1;
        private Button inStockButton;
        private Button offersButton;
        private Button outStockButton;
        private Label label7;
        private Button manageButton;
    }
}