using Lab1_LoginRegistration.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_LoginRegistration
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var usersList = UserRepository.getUsers();

            foreach (var user in usersList)
            {
                if (username == user.Username && password == user.Password)
                {
                    MessageBox.Show("User"+username+"is successfully logged in!", "", MessageBoxButtons.OK);
                    return;
                }
            }

            MessageBox.Show("Entered credentials are not valid!", "", MessageBoxButtons.OK);
                       
        }
    }
}
