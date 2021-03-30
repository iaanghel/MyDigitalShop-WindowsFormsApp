using BusinessLogic;
using Entities;
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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text)) { 
                MessageBox.Show("Utilizatorul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Parola nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            BLLogIn bl = new BLLogIn();
            UserModel user = bl.CheckUser(txtUserName.Text,txtPassword.Text, out bool status);
            
            if (status)
            {
                MainMenuForm mainMenu = new MainMenuForm(user.UserId);
                mainMenu.Show();
                this.Hide();
                mainMenu.FormClosed += MainMenu_FormClosed;

            }
            else { MessageBox.Show("User sau Parola incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error); }

      
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
            registerForm.FormClosed += RegisterForm_FormClosed;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
