using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnRregister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Utilizatorul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Parola nu este completata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Confirmati parola", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool status;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            if (password != confirmPassword)
            {
                MessageBox.Show("Parolele trebuie sa corespunda");
                return;
            }
            BLLogIn bl = new BLLogIn();
            bl.RegisterUser(userName, password, out status);
            if(status == false)
            {
                MessageBox.Show("Utilizatorul exista deja");
                return;
            }

            else
            {
                MessageBox.Show("Utilizatorul inrefistrat cu succes");
                LogInForm logInForm = new LogInForm();
                this.Hide();
                logInForm.Show();
                

            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();

        }
    }
}
