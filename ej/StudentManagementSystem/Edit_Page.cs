using System;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class Edit_Page : Form
    {
        // Reference to the student page
        private Student_Page studentPageForm;

        public Edit_Page(Student_Page form)
        {
            InitializeComponent();
            studentPageForm = form;

            // Load current data into the form
            nameTextBox.Text = studentPageForm.studentName;
            ageTextBox.Text = studentPageForm.studentAge;
            addressTextBox.Text = studentPageForm.studentAddress;
            contactTextBox.Text = studentPageForm.studentContact;
            emailTextBox.Text = studentPageForm.studentEmail;

            // Set up the course dropdown
            courseComboBox.Items.Add("ABEL");
            courseComboBox.Items.Add("BSBA");
            courseComboBox.Items.Add("BSIT");
            courseComboBox.Items.Add("BPA");
            courseComboBox.Text = studentPageForm.studentCourse;

            // Set up the year dropdown
            yearComboBox.Items.Add("First");
            yearComboBox.Items.Add("Second");
            yearComboBox.Items.Add("Third");
            yearComboBox.Items.Add("Fourth");
            yearComboBox.Text = studentPageForm.studentYear;

            guardianTextBox.Text = studentPageForm.studentGuardian;
            guardianContactTextBox.Text = studentPageForm.guardianContact;
            hobbiesTextBox.Text = studentPageForm.studentHobbies;
            nicknameTextBox.Text = studentPageForm.studentNickname;
        }

        // Save button click event
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Check for required fields
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(ageTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(contactTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(courseComboBox.Text) ||
                string.IsNullOrWhiteSpace(yearComboBox.Text) || string.IsNullOrWhiteSpace(guardianTextBox.Text) || string.IsNullOrWhiteSpace(guardianContactTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }

            // Validate age and contact number
            if (!IsNumeric(ageTextBox.Text))
            {
                MessageBox.Show("Age must be a number!");
                return;
            }

            if (!IsNumeric(contactTextBox.Text))
            {
                MessageBox.Show("Contact number must be a number!");
                return;
            }

            if (!IsNumeric(guardianContactTextBox.Text))
            {
                MessageBox.Show("Guardian contact number must be a number!");
                return;
            }

            // Update student information
            studentPageForm.studentName = nameTextBox.Text;
            studentPageForm.studentAge = ageTextBox.Text;
            studentPageForm.studentAddress = addressTextBox.Text;
            studentPageForm.studentContact = contactTextBox.Text;
            studentPageForm.studentEmail = emailTextBox.Text;
            studentPageForm.studentCourse = courseComboBox.Text;
            studentPageForm.studentYear = yearComboBox.Text;
            studentPageForm.studentGuardian = guardianTextBox.Text;
            studentPageForm.guardianContact = guardianContactTextBox.Text;
            studentPageForm.studentHobbies = hobbiesTextBox.Text;
            studentPageForm.studentNickname = nicknameTextBox.Text;

            MessageBox.Show("Profile successfully updated!");
            this.Close();
        }

        // Simple method to check if a string is a number
        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}