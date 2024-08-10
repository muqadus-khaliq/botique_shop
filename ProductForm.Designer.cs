namespace BOTIQUE_SHOP
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearchproducts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btndeleteproducts = new System.Windows.Forms.Button();
            this.cmbproductitem = new System.Windows.Forms.ComboBox();
            this.cmbprductname = new System.Windows.Forms.ComboBox();
            this.btnshowproducts = new System.Windows.Forms.Button();
            this.btnaddproducts = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.cmbproducttype = new System.Windows.Forms.ComboBox();
            this.txtproductdescription = new System.Windows.Forms.TextBox();
            this.txtquantityinstock = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblquantityinstock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnbrowse);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnsearchproducts);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblmessage);
            this.groupBox1.Controls.Add(this.btndeleteproducts);
            this.groupBox1.Controls.Add(this.cmbproductitem);
            this.groupBox1.Controls.Add(this.cmbprductname);
            this.groupBox1.Controls.Add(this.btnshowproducts);
            this.groupBox1.Controls.Add(this.btnaddproducts);
            this.groupBox1.Controls.Add(this.pBox);
            this.groupBox1.Controls.Add(this.cmbproducttype);
            this.groupBox1.Controls.Add(this.txtproductdescription);
            this.groupBox1.Controls.Add(this.txtquantityinstock);
            this.groupBox1.Controls.Add(this.txtproductid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblquantityinstock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product-Detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(779, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 47);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(566, 164);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(98, 36);
            this.btnbrowse.TabIndex = 22;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(615, 296);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(70, 39);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearchproducts
            // 
            this.btnsearchproducts.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchproducts.Location = new System.Drawing.Point(368, 49);
            this.btnsearchproducts.Name = "btnsearchproducts";
            this.btnsearchproducts.Size = new System.Drawing.Size(98, 48);
            this.btnsearchproducts.TabIndex = 21;
            this.btnsearchproducts.Text = "Search Products";
            this.btnsearchproducts.UseVisualStyleBackColor = true;
            this.btnsearchproducts.Click += new System.EventHandler(this.btnsearchproducts_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(488, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(779, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.BackColor = System.Drawing.Color.Red;
            this.lblmessage.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(18, 315);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(114, 29);
            this.lblmessage.TabIndex = 20;
            this.lblmessage.Text = "Message";
            // 
            // btndeleteproducts
            // 
            this.btndeleteproducts.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteproducts.Location = new System.Drawing.Point(779, 292);
            this.btndeleteproducts.Name = "btndeleteproducts";
            this.btndeleteproducts.Size = new System.Drawing.Size(105, 47);
            this.btndeleteproducts.TabIndex = 16;
            this.btndeleteproducts.Text = "Delete Product";
            this.btndeleteproducts.UseVisualStyleBackColor = true;
            this.btndeleteproducts.Click += new System.EventHandler(this.btndeleteproducts_Click);
            // 
            // cmbproductitem
            // 
            this.cmbproductitem.FormattingEnabled = true;
            this.cmbproductitem.Items.AddRange(new object[] {
            "Enchanted Garden Maxi Dress",
            "Midnight Sparkle Cocktail Dress",
            "Urban Chic Shift Dress",
            "Vintage Lace Evening Gown",
            "Boho Blossom Summer Dress"});
            this.cmbproductitem.Location = new System.Drawing.Point(159, 132);
            this.cmbproductitem.Name = "cmbproductitem";
            this.cmbproductitem.Size = new System.Drawing.Size(165, 23);
            this.cmbproductitem.TabIndex = 19;
            // 
            // cmbprductname
            // 
            this.cmbprductname.FormattingEnabled = true;
            this.cmbprductname.Items.AddRange(new object[] {
            "Kurti",
            "Salwar Qameez",
            "Bridal dress",
            "boys pent shirts ",
            "boys suit",
            "sari",
            "frok",
            "",
            " "});
            this.cmbprductname.Location = new System.Drawing.Point(159, 84);
            this.cmbprductname.Name = "cmbprductname";
            this.cmbprductname.Size = new System.Drawing.Size(165, 23);
            this.cmbprductname.TabIndex = 18;
            // 
            // btnshowproducts
            // 
            this.btnshowproducts.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowproducts.Location = new System.Drawing.Point(776, 229);
            this.btnshowproducts.Name = "btnshowproducts";
            this.btnshowproducts.Size = new System.Drawing.Size(105, 44);
            this.btnshowproducts.TabIndex = 17;
            this.btnshowproducts.Text = "Show Products";
            this.btnshowproducts.UseVisualStyleBackColor = true;
            this.btnshowproducts.Click += new System.EventHandler(this.btnshowproducts_Click);
            // 
            // btnaddproducts
            // 
            this.btnaddproducts.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproducts.Location = new System.Drawing.Point(779, 172);
            this.btnaddproducts.Name = "btnaddproducts";
            this.btnaddproducts.Size = new System.Drawing.Size(105, 46);
            this.btnaddproducts.TabIndex = 15;
            this.btnaddproducts.Text = "Add Products";
            this.btnaddproducts.UseVisualStyleBackColor = true;
            this.btnaddproducts.Click += new System.EventHandler(this.btnaddproducts_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(501, 40);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(231, 120);
            this.pBox.TabIndex = 14;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbproducttype
            // 
            this.cmbproducttype.FormattingEnabled = true;
            this.cmbproducttype.Items.AddRange(new object[] {
            "Dresses",
            "Shoes",
            "Accessories",
            "Handbags",
            "Outerwear"});
            this.cmbproducttype.Location = new System.Drawing.Point(159, 172);
            this.cmbproducttype.Name = "cmbproducttype";
            this.cmbproducttype.Size = new System.Drawing.Size(165, 23);
            this.cmbproducttype.TabIndex = 13;
            // 
            // txtproductdescription
            // 
            this.txtproductdescription.Location = new System.Drawing.Point(159, 262);
            this.txtproductdescription.Multiline = true;
            this.txtproductdescription.Name = "txtproductdescription";
            this.txtproductdescription.Size = new System.Drawing.Size(165, 47);
            this.txtproductdescription.TabIndex = 12;
            this.txtproductdescription.TextChanged += new System.EventHandler(this.txtproductdescription_TextChanged);
            // 
            // txtquantityinstock
            // 
            this.txtquantityinstock.Location = new System.Drawing.Point(159, 217);
            this.txtquantityinstock.Name = "txtquantityinstock";
            this.txtquantityinstock.Size = new System.Drawing.Size(165, 22);
            this.txtquantityinstock.TabIndex = 11;
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(159, 38);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(165, 22);
            this.txtproductid.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "ProductDescription";
            // 
            // lblquantityinstock
            // 
            this.lblquantityinstock.AutoSize = true;
            this.lblquantityinstock.BackColor = System.Drawing.Color.White;
            this.lblquantityinstock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantityinstock.Location = new System.Drawing.Point(20, 229);
            this.lblquantityinstock.Name = "lblquantityinstock";
            this.lblquantityinstock.Size = new System.Drawing.Size(107, 16);
            this.lblquantityinstock.TabIndex = 5;
            this.lblquantityinstock.Text = "QuantityInStock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ProductType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProductItem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ProductName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ProductID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(881, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product-Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblquantityinstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproductdescription;
        private System.Windows.Forms.TextBox txtquantityinstock;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.ComboBox cmbproducttype;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshowproducts;
        private System.Windows.Forms.Button btndeleteproducts;
        private System.Windows.Forms.Button btnaddproducts;
        private System.Windows.Forms.ComboBox cmbproductitem;
        private System.Windows.Forms.ComboBox cmbprductname;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnsearchproducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}