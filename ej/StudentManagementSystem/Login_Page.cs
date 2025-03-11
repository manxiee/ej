using System;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class Login_Page : Form
    {
        // Simple mock data
        string username = "ejpower";
        string password = "ejpower123;
        int attempts = 0;

        public Login_Page()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string inputUser = userTextBox.Text;
            string inputPass = passTextBox.Text;

            // Check login
            if (inputUser == username && inputPass == password)
            {
                MessageBox.Show("Login successful!");

                // Open student page
                Student_Page studentForm = new Student_Page();
                this.Hide();
                studentForm.Show();
            }
            else
            {
                attempts++;

                // Simple error messages
                if (inputUser != username && inputPass != password)
                    MessageBox.Show("Wrong username and password!");
                else if (inputUser != username)
                    MessageBox.Show("Wrong username!");
                else
                    MessageBox.Show("Wrong password!");

                // Check if reached max attempts
                if (attempts >= 5)
                {
                    MessageBox.Show("Too many attempts! Reset your password here: www.resetpassword.com");
                    attempts = 0; // Reset attempts
                }
            }
        }
    }
}