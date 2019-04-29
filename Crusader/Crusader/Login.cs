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
    public partial class Login : Form
    {
        UserEntities ue;

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please type in Username or Password");
                }
                else
                {
                    User u = ue.Users.Where(o => o.UserName == txtUsername.Text).Single();
                    if (u != null)
                    {
                        if (u.UserPassword == txtPassword.Text)
                        {
                            if (u.IsAdmin != "true")
                            {
                                MessageBox.Show("Welcome player");
                                new SearchCategory().ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Welcome Admin");
                                new AdminPanel().ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new SignUp().ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zhengruiDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.zhengruiDataSet.User);

            ue = new UserEntities();
        }
    }
}
