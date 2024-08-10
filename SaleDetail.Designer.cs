namespace BOTIQUE_SHOP
{
    partial class SaleDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbsalescustomerid = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botiqueShopDataSet5 = new BOTIQUE_SHOP.BotiqueShopDataSet5();
            this.cmbsalestype = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botiqueShopDataSet3 = new BOTIQUE_SHOP.BotiqueShopDataSet3();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalesDiscreption = new System.Windows.Forms.TextBox();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcustomerid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salesTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botiqueShopDataSet2 = new BOTIQUE_SHOP.BotiqueShopDataSet2();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.botiqueShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botiqueShopDataSet = new BOTIQUE_SHOP.BotiqueShopDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.txtunityprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtSalesDetails = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.btnSaves = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new BOTIQUE_SHOP.BotiqueShopDataSetTableAdapters.SalesTableAdapter();
            this.botiqueShopDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesTypeTableAdapter = new BOTIQUE_SHOP.BotiqueShopDataSet2TableAdapters.SalesTypeTableAdapter();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.productTableAdapter = new BOTIQUE_SHOP.BotiqueShopDataSet3TableAdapters.productTableAdapter();
            this.customerTableAdapter = new BOTIQUE_SHOP.BotiqueShopDataSet5TableAdapters.customerTableAdapter();
            this.botiqueShopDataSet6 = new BOTIQUE_SHOP.BotiqueShopDataSet6();
            this.salesTypeTableAdapter1 = new BOTIQUE_SHOP.BotiqueShopDataSet6TableAdapters.SalesTypeTableAdapter();
            this.tableAdapterManager = new BOTIQUE_SHOP.BotiqueShopDataSet6TableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cmbsalescustomerid);
            this.groupBox1.Controls.Add(this.cmbsalestype);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSalesDiscreption);
            this.groupBox1.Controls.Add(this.txtSalesAmount);
            this.groupBox1.Controls.Add(this.txtSales);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblcustomerid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbsalescustomerid
            // 
            this.cmbsalescustomerid.DataSource = this.customerBindingSource;
            this.cmbsalescustomerid.DisplayMember = "CustomerName";
            this.cmbsalescustomerid.FormattingEnabled = true;
            this.cmbsalescustomerid.Location = new System.Drawing.Point(479, 40);
            this.cmbsalescustomerid.Name = "cmbsalescustomerid";
            this.cmbsalescustomerid.Size = new System.Drawing.Size(154, 21);
            this.cmbsalescustomerid.TabIndex = 7;
            this.cmbsalescustomerid.ValueMember = "CustomerID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.botiqueShopDataSet5;
            // 
            // botiqueShopDataSet5
            // 
            this.botiqueShopDataSet5.DataSetName = "BotiqueShopDataSet5";
            this.botiqueShopDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbsalestype
            // 
            this.cmbsalestype.DataSource = this.productBindingSource;
            this.cmbsalestype.DisplayMember = "ProductID";
            this.cmbsalestype.FormattingEnabled = true;
            this.cmbsalestype.Location = new System.Drawing.Point(295, 172);
            this.cmbsalestype.Name = "cmbsalestype";
            this.cmbsalestype.Size = new System.Drawing.Size(121, 21);
            this.cmbsalestype.TabIndex = 6;
            this.cmbsalestype.ValueMember = "Productdescription";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.botiqueShopDataSet3;
            // 
            // botiqueShopDataSet3
            // 
            this.botiqueShopDataSet3.DataSetName = "BotiqueShopDataSet3";
            this.botiqueShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sales Type";
            // 
            // txtSalesDiscreption
            // 
            this.txtSalesDiscreption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesDiscreption.Location = new System.Drawing.Point(479, 88);
            this.txtSalesDiscreption.Name = "txtSalesDiscreption";
            this.txtSalesDiscreption.Size = new System.Drawing.Size(154, 24);
            this.txtSalesDiscreption.TabIndex = 1;
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesAmount.Location = new System.Drawing.Point(124, 91);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(147, 24);
            this.txtSalesAmount.TabIndex = 1;
            // 
            // txtSales
            // 
            this.txtSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSales.Location = new System.Drawing.Point(124, 38);
            this.txtSales.Name = "txtSales";
            this.txtSales.ReadOnly = true;
            this.txtSales.Size = new System.Drawing.Size(147, 24);
            this.txtSales.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 24);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sales Discription";
            // 
            // lblcustomerid
            // 
            this.lblcustomerid.AutoSize = true;
            this.lblcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerid.Location = new System.Drawing.Point(303, 42);
            this.lblcustomerid.Name = "lblcustomerid";
            this.lblcustomerid.Size = new System.Drawing.Size(147, 18);
            this.lblcustomerid.TabIndex = 2;
            this.lblcustomerid.Text = "Sales Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales ID";
            // 
            // salesTypeBindingSource
            // 
            this.salesTypeBindingSource.DataMember = "SalesType";
            this.salesTypeBindingSource.DataSource = this.botiqueShopDataSet2;
            // 
            // botiqueShopDataSet2
            // 
            this.botiqueShopDataSet2.DataSetName = "BotiqueShopDataSet2";
            this.botiqueShopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.botiqueShopDataSetBindingSource;
            // 
            // botiqueShopDataSetBindingSource
            // 
            this.botiqueShopDataSetBindingSource.DataSource = this.botiqueShopDataSet;
            this.botiqueShopDataSetBindingSource.Position = 0;
            // 
            // botiqueShopDataSet
            // 
            this.botiqueShopDataSet.DataSetName = "BotiqueShopDataSet";
            this.botiqueShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sales Details ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(531, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantity";
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(731, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Unit Price";
            this.label10.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.cmbproduct);
            this.groupBox2.Controls.Add(this.txtunityprice);
            this.groupBox2.Controls.Add(this.txtquantity);
            this.groupBox2.Controls.Add(this.txtSalesDetails);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale-Detail";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(898, 148);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cmbproduct
            // 
            this.cmbproduct.DataSource = this.productBindingSource;
            this.cmbproduct.DisplayMember = "Productdescription";
            this.cmbproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(371, 27);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(134, 24);
            this.cmbproduct.TabIndex = 2;
            this.cmbproduct.ValueMember = "ProductID";
            // 
            // txtunityprice
            // 
            this.txtunityprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunityprice.Location = new System.Drawing.Point(811, 27);
            this.txtunityprice.Name = "txtunityprice";
            this.txtunityprice.Size = new System.Drawing.Size(123, 22);
            this.txtunityprice.TabIndex = 1;
            this.txtunityprice.TextChanged += new System.EventHandler(this.txtunityprice_TextChanged);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(600, 29);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(125, 22);
            this.txtquantity.TabIndex = 1;
            // 
            // txtSalesDetails
            // 
            this.txtSalesDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesDetails.Location = new System.Drawing.Point(141, 27);
            this.txtSalesDetails.Name = "txtSalesDetails";
            this.txtSalesDetails.ReadOnly = true;
            this.txtSalesDetails.Size = new System.Drawing.Size(123, 22);
            this.txtSalesDetails.TabIndex = 1;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.IndianRed;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(787, 97);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(146, 54);
            this.AddProduct.TabIndex = 2;
            this.AddProduct.Text = "AddProduct";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // btnSaves
            // 
            this.btnSaves.BackColor = System.Drawing.Color.IndianRed;
            this.btnSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaves.Location = new System.Drawing.Point(787, 32);
            this.btnSaves.Name = "btnSaves";
            this.btnSaves.Size = new System.Drawing.Size(146, 49);
            this.btnSaves.TabIndex = 2;
            this.btnSaves.Text = "SalesSave";
            this.btnSaves.UseVisualStyleBackColor = false;
            this.btnSaves.Click += new System.EventHandler(this.btnSaves_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.botiqueShopDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // botiqueShopDataSetBindingSource1
            // 
            this.botiqueShopDataSetBindingSource1.DataSource = this.botiqueShopDataSet;
            this.botiqueShopDataSetBindingSource1.Position = 0;
            // 
            // salesTypeTableAdapter
            // 
            this.salesTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Green;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(800, 209);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(102, 45);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(962, 209);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(87, 45);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Exit";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnbutton_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // botiqueShopDataSet6
            // 
            this.botiqueShopDataSet6.DataSetName = "BotiqueShopDataSet6";
            this.botiqueShopDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTypeTableAdapter1
            // 
            this.salesTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SalesTypeTableAdapter = this.salesTypeTableAdapter1;
            this.tableAdapterManager.UpdateOrder = BOTIQUE_SHOP.BotiqueShopDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1263, 516);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnSaves);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale-SaleDetail";
            this.Load += new System.EventHandler(this.Form5_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botiqueShopDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcustomerid;
        private System.Windows.Forms.TextBox txtSalesDiscreption;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.TextBox txtunityprice;
        private System.Windows.Forms.TextBox txtSalesDetails;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button btnSaves;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbsalestype;
        private BotiqueShopDataSet botiqueShopDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private BotiqueShopDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private System.Windows.Forms.BindingSource botiqueShopDataSetBindingSource;
        private System.Windows.Forms.BindingSource botiqueShopDataSetBindingSource1;
        private System.Windows.Forms.ComboBox cmbsalescustomerid;
        private BotiqueShopDataSet2 botiqueShopDataSet2;
        private System.Windows.Forms.BindingSource salesTypeBindingSource;
        private BotiqueShopDataSet2TableAdapters.SalesTypeTableAdapter salesTypeTableAdapter;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclear;
        private BotiqueShopDataSet3 botiqueShopDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private BotiqueShopDataSet3TableAdapters.productTableAdapter productTableAdapter;
        private BotiqueShopDataSet5 botiqueShopDataSet5;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BotiqueShopDataSet5TableAdapters.customerTableAdapter customerTableAdapter;
        private BotiqueShopDataSet6 botiqueShopDataSet6;
        private BotiqueShopDataSet6TableAdapters.SalesTypeTableAdapter salesTypeTableAdapter1;
        private BotiqueShopDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
    }
}