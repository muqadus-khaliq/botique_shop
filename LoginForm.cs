using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOTIQUE_SHOP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin")
            {
                
            }
            else
            {
                MessageBox.Show("plz enter the right name");
                txtusername.Focus();
                txtusername.Clear();
            }
        }
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text == "muqadus")
            {
               
            }
            else
            {
                 
                   
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtpassword.Text) == true)
            {
                errorProvider1.SetError(this.txtpassword, ("plz enter the password first"));
            }
            else if (string.IsNullOrEmpty(txtusername.Text) == true)
            {
                errorProvider1.SetError(this.txtusername, ("plz enter the name first"));
            }
            else
            {
                BotiqueShop form = new BotiqueShop();
                form.Show();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
           
        }

       
    }
}

        

             
        





 
 

 

 

