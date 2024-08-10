using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BOTIQUE_SHOP
{
    
    public partial class SaleDetail : Form
    {
        //public object BotiqueShopDataSet1 { get; private set; }
        private float totalsaleamount;

       // public object BotiqueShopDataSet1 { get; private set; }

        public SaleDetail()
        {
            InitializeComponent();
            totalsaleamount = 0.0f;
            txtSalesAmount.Text = totalsaleamount.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void AddProduct_Click(object sender, EventArgs e)
        {
            string product = cmbproduct.SelectedValue.ToString();
            string quantity = txtquantity.Text;
            string unitprice = txtunityprice.Text;
            // Create ListViewItem to add values to ListView
            ListViewItem item = new ListViewItem(new[] { product, quantity, unitprice });
            // Add the ListViewItem to the ListView
            listView1.Items.Add(item);
            if (listView1.Columns.Count == 0)
            {

                listView1.Columns.Add("product", 100); // Adjust column width as needed
                listView1.Columns.Add("quantity", 100); // Adjust column width as needed
                listView1.Columns.Add("unitprice", 100);
            }
            listView1.Refresh();
            totalsaleamount = totalsaleamount + (Convert.ToInt32(txtquantity.Text) * Convert.ToInt32(txtunityprice.Text));
            txtSalesAmount.Text = totalsaleamount.ToString();
        }


        private void btnSaves_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new
     SqlConnection(Properties.Settings.Default.Connectionstring))

            {
                // Create a command to insert the image data
                string sale = "INSERT INTO [Sales]  (SalesCustomerID,SalesAmount,SalesType,SalesDescription) VALUES(@SalesCustomerID,@SalesAmount,@SalesType,@SalesDescription); Select SCOPE_IDENTITY()";
                SqlCommand command = new SqlCommand(sale, connection);


                command.Parameters.AddWithValue("@SalesCustomerID",
               Convert.ToInt32(cmbsalescustomerid.SelectedValue.ToString()));

                command.Parameters.AddWithValue("@SalesAmount", txtSalesAmount.Text);

                command.Parameters.AddWithValue("@SalesType", Convert.ToInt32(cmbsalestype.Text));

                command.Parameters.AddWithValue("@SalesDescription",
               txtSalesDiscreption.Text);

                connection.Open();

                int lastSalesID = Convert.ToInt32(command.ExecuteScalar());

                String SaleDetail = "INSERT INTO SaleDetail (Product, Quantity,Unitprice) VALUES(@product, @quantity,@unitprice)";

                SqlCommand sqlCommand = new SqlCommand(SaleDetail, connection);

                foreach (ListViewItem currproduct in listView1.Items)
                {

                    


                    sqlCommand.Parameters.AddWithValue("@product",
                   Convert.ToInt32(currproduct.SubItems[0].Text));

                    sqlCommand.Parameters.AddWithValue("@quantity", Convert.ToInt32(currproduct.SubItems[1].Text));

                    sqlCommand.Parameters.AddWithValue("@unitprice", Convert.ToInt32(currproduct.SubItems[2].Text));




                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                }
                connection.Close();
                MessageBox.Show("Sale Saved Successfuly");
            }
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botiqueShopDataSet5.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.botiqueShopDataSet5.customer);
            // TODO: This line of code loads data into the 'botiqueShopDataSet3.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.botiqueShopDataSet3.product);
            // TODO: This line of code loads data into the 'botiqueShopDataSet2.SalesType' table. You can move, or remove it, as needed.
            this.salesTypeTableAdapter.Fill(this.botiqueShopDataSet2.SalesType);





        }

        private void btnback_Click(object sender, EventArgs e)
        {

            ProductForm form = new ProductForm();
            form.ShowDialog();
        }

        private void btnbutton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.salesTypeTableAdapter1.FillBy(this.botiqueShopDataSet6.SalesType);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.salesTypeTableAdapter.FillBy(this.botiqueShopDataSet2.SalesType);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.botiqueShopDataSet3.product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtunityprice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    

