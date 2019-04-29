using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crusader
{
    public partial class SignUp : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String q = "";
        SqlConnection conn = null;

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string fullName = txtFullName.Text;
                string Gender = txtGender.Text;
                string Email = txtEmail.Text;
                string Country = txtCountry.Text;
                string userName = txtUserName.Text;
                string userPassword = txtUserPassword.Text;
                string creditCard = txtCreditCard.Text;
                string birthDate = txtBirthDate.Text;
                string Phone = txtPhone.Text;
                q = "INSERT Crusader.[User](FullName, Gender, Email, Country, UserName, UserPassword, CreditCard, BirthDate, Phone, IsAdmin) VALUES (@FullName , @Gender, @Email, @Country, @UserName, @UserPassword, @CreditCard, @BirthDate, @Phone, @IsAdmin)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@fullName", fullName);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Country", Country);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@UserPassword", userPassword);
                cmd.Parameters.AddWithValue("@CreditCard", creditCard);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@IsAdmin", "false");
                cmd.ExecuteNonQuery();
                
                panel.Enabled = false;
                MessageBox.Show("Successfully Sign Up");
                btnSignUp.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conn_string);
        }
    }
}
