using System;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class Student_Page : Form
    {
        // Student info - simple way to store data
        public string studentName = "Charles Dave Bugarin";
        public string studentAge = "21";
        public string studentAddress = "M.H.D.P bbang, pang";
        public string studentContact = "63+956 436 6036";
        public string studentEmail = "bogartpenta@gmail.com";
        public string studentCourse = "BSIT";
        public string studentYear = "third";
        public string studentGuardian = "Dave Bugarin";
        public string guardianContact = "63+912 945 1235";
        public string studentHobbies = "Gaming";
        public string studentNickname = "CD";

        public Student_Page()
        {
            InitializeComponent();
            DisplayStudentInfo();

            // Connect the Edit/Update button to the event handler
            // Make sure this matches the actual name of your button from the designer
            this.editButton.Click += new EventHandler(editButton_Click);

            // If your button is named differently (like updateButton), use that name instead
            // For example, if it's named "updateButton" in the designer:
            // this.updateButton.Click += new EventHandler(editButton_Click);
        }

        // Show the student information
        private void DisplayStudentInfo()
        {
            nameLabel.Text = studentName;
            ageLabel.Text = studentAge;
            addressLabel.Text = studentAddress;
            contactLabel.Text = studentContact;
            emailLabel.Text = studentEmail;
            courseYearLabel.Text = studentCourse + ", " + studentYear + " Year";
            guardianLabel.Text = studentGuardian;
            guardianContactLabel.Text = guardianContact;
            hobbiesLabel.Text = studentHobbies;
            nicknameLabel.Text = studentNickname;
        }

        // Open edit form when edit button is clicked
        private void editButton_Click(object sender, EventArgs e)
        {
            Edit_Page editForm = new Edit_Page(this);
            editForm.ShowDialog();
            // Update the display after editing
            DisplayStudentInfo();
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            // Code for  image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Assuming you have a PictureBox named profilePictureBox
                profilePictureBox.ImageLocation = openFileDialog.FileName;
            }
        }

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            // Code for changing an image can go here
            // This can be the same as addImageButton_Click
            addImageButton_Click(sender, e);
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            // Any code for when the profile picture is clicked
        }

        // The following methods can be removed if they don't contain any functionality
        // or kept empty if they're required by the Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
    }
}