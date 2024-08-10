using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BOTIQUE_SHOP
{

    public partial class ProductForm : Form
    {
        private Boolean isloaded;
        public ProductForm()
        {
            InitializeComponent();
        }


        //RETRIEVE IMAGE







        /// <summary>//////////////////////////////////////////
        /// //////////////////////////////////////////////////////////////////////////////////
        /// </summary>//////////////////////////////////////////////



        private void btnaddproducts_Click(object sender, EventArgs e)

        {
            if (pBox.Image != null)
            {
                // Convert image to byte array
                System.Drawing.Image image = pBox.Image;
                MemoryStream ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                byte[] imageData = ms.ToArray();


                String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BotiqueShop;Integrated Security=True";

                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();



                string insertStmt = "INSERT INTO product VALUES (@ProductID, @ProductName, @ProductItem, @ProductType,@Image, @productDescription, @QuantityInStock)";
                SqlCommand command = new SqlCommand(insertStmt, connection);
                command.Parameters.AddWithValue("@ProductID", Convert.ToInt32(txtproductid.Text));
                command.Parameters.AddWithValue("@ProductName", cmbprductname.Text);
                command.Parameters.AddWithValue("@ProductItem", cmbproductitem.Text);
                command.Parameters.AddWithValue("@ProductType", cmbproducttype.Text);
                command.Parameters.AddWithValue("@Image", imageData);
                command.Parameters.AddWithValue("@productDescription", txtproductdescription.Text);
                command.Parameters.AddWithValue("@QuantityInStock", txtquantityinstock.Text);
                //command.Parameters.AddWithValue("@image", imageData);
                // Open connection and execute command
                 
                command.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully.");
            }
        
     else
     {
         MessageBox.Show("Please select an image to save.");
     }
             
















}

        private void btnshowproducts_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BotiqueShop;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string selectQuery = "SELECT * FROM product";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);


            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            connection.Close();
        }








        private void btnsearchproducts_Click(object sender, EventArgs e)
        {
            int productid = Convert.ToInt32(txtproductid.Text);

            string connection = Properties.Settings.Default.Connectionstring;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand Command = new SqlCommand();
            Command.Connection = con;
            Command.CommandText = "SELECT * FROM product WHERE ProductID=@productid";
            Command.Parameters.AddWithValue("@ProductID", productid);
            con.Open();


            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {


                cmbprductname.Text = reader.GetString(reader.GetOrdinal("ProductName"));
                cmbproductitem.Text = reader.GetString(reader.GetOrdinal("ProductItem"));
                cmbproducttype.Text = reader.GetString(reader.GetOrdinal("ProductType"));

                txtquantityinstock.Text = reader.GetString(reader.GetOrdinal("QuantityInStock"));
                txtproductdescription.Text = reader.GetString(reader.GetOrdinal("ProductDescription"));
                 
                byte[] imageData;
                // First call to get the length of binary data that we want to read back
                long bufLength = reader.GetBytes(reader.GetOrdinal("image"), 0, null, 0, 0);
                // Now allocate a buffer big enough to receive the  bits...
                imageData = new byte[bufLength];
                // Get all bytes from the reader
                reader.GetBytes(reader.GetOrdinal("image"), 0, imageData, 0, (int)bufLength);
                // Transfer everything to the Image property of  the picture box....
                MemoryStream ms = new MemoryStream(imageData);
                ms.Position = 0;
                pBox.Image = System.Drawing.Image.FromStream(ms);
                isloaded = true;
            }
            reader.Close();
            con.Close();
        }
    

           /*reader.Close();
            con.Close();
            isloaded = true;

        }*/

        private void btndeleteproducts_Click(object sender, EventArgs e)
        {
            if (isloaded)
            {

                

                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BotiqueShop;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                string deleteStmt = "DELETE  FROM Product WHERE ProductID=@ProductID";
                SqlCommand deleteCommand = new SqlCommand(deleteStmt, connection);
                deleteCommand.Parameters.AddWithValue("@ProductID", txtproductid.Text);

                connection.Open();
                int rowsAffected = deleteCommand.ExecuteNonQuery();
                //con.Close();

                if (rowsAffected > 0)
                {
                    // ClearForm();
                    lblmessage.Text = "Message: Data Deleted Successfully!";
                }
                else
                {
                    lblmessage.Text = "Message: Data Couldn't be Deleted!";
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Drawing.Image image = pBox.Image;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            Byte[] imageData = ms.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtproductid.Text) == true)
            {
                errorProvider1.SetError(this.txtproductid, ("plz enter the productid first"));
            }
            else if (string.IsNullOrEmpty(cmbprductname.Text) == true)
            {
                errorProvider1.SetError(this.cmbprductname, ("plz enter the name first"));
            }
            else
            {
                SaleDetail form = new SaleDetail();
                form.ShowDialog();

            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtproductid.Text = string.Empty;
            cmbprductname.Text = string.Empty;
            cmbproductitem.Text = string.Empty;
            cmbproducttype.Text = string.Empty;
            txtproductdescription.Text = string.Empty;
            txtquantityinstock.Text = string.Empty;
            dataGridView1.DataSource = null;
            
        }

        private void txtproductdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images File(*.png;*.jpeg;*.bng;*.jpg)|*.png;*.jpeg;*.bng;*.jpg";
            openFileDialog1.Title = "select image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox.Load(openFileDialog1.FileName);
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isloaded)
            {

                string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BotiqueShop;Integrated Security=True";

                SqlConnection con = new SqlConnection(connection);

                string insertStmt = "UPDATE product SET productid=@productid, productname=@productname, productitem=@productitem,producttype=@producttype,quantityinstock=@quantityinstock,productdescription=@productdescription WHERE  productid=@productid";
                SqlCommand UpdateCommand = new SqlCommand(insertStmt, con);
                UpdateCommand.Parameters.AddWithValue("@productid", txtproductid.Text);
                UpdateCommand.Parameters.AddWithValue("@productname", cmbprductname.Text);
                UpdateCommand.Parameters.AddWithValue("@productitem", cmbproductitem.Text);
                UpdateCommand.Parameters.AddWithValue("@producttype", cmbproducttype.Text);
                UpdateCommand.Parameters.AddWithValue("@quantityinstock", txtquantityinstock.Text);
                UpdateCommand.Parameters.AddWithValue("@productdescription", txtproductdescription.Text);
                //UpdateCommand.Parameters.AddWithValue("@image", pBox.Text);
                con.Open();
                int rowsAffected = UpdateCommand.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                     
                    lblmessage.Text = "Message: Data  Updated successfully!";
                }
                else
                {
                    lblmessage.Text = "Message: Data Couldn't be Updated!";
                }

            }
        }

        
        
    }
    }

    




        