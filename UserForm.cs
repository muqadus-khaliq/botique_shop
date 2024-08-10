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

namespace BOTIQUE_SHOP
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

         

        private void btninsert_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BotiqueShop;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();



            string insertStmt = "INSERT INTO BotiqueUser (UserID,UserName,UserPhoneNo, Useremail,UserAddress,Password) VALUES (@UserID,@UserName,@UserPhoneNo,@Useremail,@UserAddress,@Password)";
            SqlCommand insertCommand = new SqlCommand(insertStmt, connection);
            insertCommand.Parameters.AddWithValue("@UserID", txtuserid.Text);
            insertCommand.Parameters.AddWithValue(@"UserName", txtUserName.Text);
            insertCommand.Parameters.AddWithValue(@"UserPhoneNo", txtPhoneNo.Text);
            insertCommand.Parameters.AddWithValue(@"Useremail", txtUserEmail.Text);
            insertCommand.Parameters.AddWithValue(@"UserAddress", txtUserAddress.Text);
            insertCommand.Parameters.AddWithValue(@"Password", "123");
            


            int rowsAffected = insertCommand.ExecuteNonQuery();


            connection.Close();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BotiqueShop;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string selectQuery = "SELECT * FROM BotiqueUser";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);


            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            connection.Close();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtuserid.Text) == true)
            {
                errorProvider1.SetError(this.txtuserid, ("plz enter the password first"));
            }
            else if (string.IsNullOrEmpty(txtUserName.Text) == true)
            {
                errorProvider1.SetError(this.txtUserName, ("plz enter the name first"));
            }
            else
            {
                ProductForm form = new ProductForm();
                form.ShowDialog();

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BotiqueShop form = new BotiqueShop();
            form.ShowDialog();
             
        }

        
            
             
private void btnclear_Click(object sender, EventArgs e)
        {
            txtuserid.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtUserEmail.Text = string.Empty;
            txtUserAddress.Text = string.Empty;
            txtPassword.Text = string.Empty;
            dataGridView1.DataSource = null;
        }
    }
    }

