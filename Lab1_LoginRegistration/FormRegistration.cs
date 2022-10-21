using Lab1_LoginRegistration.Models;
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
    public partial class FormRegistration : Form
    {
        FormLogin frmLogin;
        public FormRegistration(FormLogin _frmLogin)
        {
            frmLogin = _frmLogin;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = GetCheckedRadioButtonIndex();
            var registrationFormData = new List<string> { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };

            if (IsRadioButtonChecked(index) == false || IsThereAnEmptyField(registrationFormData) == true)
                return;

            AddNewUser(index, registrationFormData);

            frmLogin.Show();
            this.Close();
        }

        private static void AddNewUser(int index, List<string> registrationFormData)
        {
            UserType usertype = (UserType)index;

            User user = new User
            {
                FirstName = registrationFormData[0],
                LastName = registrationFormData[1],
                Username = registrationFormData[2],
                Password = registrationFormData[3],
                UserType = usertype
            };

            UserRepository.users.Add(user);
        }

        private bool IsThereAnEmptyField(List<String> data)
        {
            string empty = data.FirstOrDefault(d => String.IsNullOrWhiteSpace(d));

            if (empty != null)
                return true;

            return false;
        }

        private bool IsRadioButtonChecked(int index)
        {
            if (index == -1)
                return false;

            return true;
        }

        private int GetCheckedRadioButtonIndex()
        {
            var radioButtons = groupboxUsertype.Controls.OfType<RadioButton>();
            var radiobtnChecked = radioButtons.FirstOrDefault(radiobtn => radiobtn.Checked);

            int index = groupboxUsertype.Controls.IndexOf(radiobtnChecked);

            return index;
        }
    }
}
