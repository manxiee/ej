using System;

namespace StudentSystem
{
    partial class Student_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.changeImageButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.courseYearLabel = new System.Windows.Forms.Label();
            this.guardianLabel = new System.Windows.Forms.Label();
            this.guardianContactLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.hobbiesLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(31, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(221, 206);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(31, 224);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(85, 23);
            this.addImageButton.TabIndex = 1;
            this.addImageButton.Text = "Add Image";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // changeImageButton
            // 
            this.changeImageButton.Location = new System.Drawing.Point(122, 224);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(87, 23);
            this.changeImageButton.TabIndex = 2;
            this.changeImageButton.Text = "Change Image";
            this.changeImageButton.UseVisualStyleBackColor = true;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(258, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(258, 34);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age:";
            this.ageLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(258, 57);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(258, 80);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(47, 13);
            this.contactLabel.TabIndex = 6;
            this.contactLabel.Text = "Contact:";
            this.contactLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(258, 103);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // courseYearLabel
            // 
            this.courseYearLabel.AutoSize = true;
            this.courseYearLabel.Location = new System.Drawing.Point(258, 131);
            this.courseYearLabel.Name = "courseYearLabel";
            this.courseYearLabel.Size = new System.Drawing.Size(43, 13);
            this.courseYearLabel.TabIndex = 8;
            this.courseYearLabel.Text = "Course:";
            this.courseYearLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // guardianLabel
            // 
            this.guardianLabel.AutoSize = true;
            this.guardianLabel.Location = new System.Drawing.Point(258, 156);
            this.guardianLabel.Name = "guardianLabel";
            this.guardianLabel.Size = new System.Drawing.Size(50, 13);
            this.guardianLabel.TabIndex = 10;
            this.guardianLabel.Text = "Guardian";
            // 
            // guardianContactLabel
            // 
            this.guardianContactLabel.AutoSize = true;
            this.guardianContactLabel.Location = new System.Drawing.Point(258, 180);
            this.guardianContactLabel.Name = "guardianContactLabel";
            this.guardianContactLabel.Size = new System.Drawing.Size(89, 13);
            this.guardianContactLabel.TabIndex = 11;
            this.guardianContactLabel.Text = "Guardian contact";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(258, 229);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(55, 13);
            this.nicknameLabel.TabIndex = 14;
            this.nicknameLabel.Text = "Nickname";
            // 
            // hobbiesLabel
            // 
            this.hobbiesLabel.AutoSize = true;
            this.hobbiesLabel.Location = new System.Drawing.Point(258, 206);
            this.hobbiesLabel.Name = "hobbiesLabel";
            this.hobbiesLabel.Size = new System.Drawing.Size(46, 13);
            this.hobbiesLabel.TabIndex = 15;
            this.hobbiesLabel.Text = "Hobbies";
            this.hobbiesLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(579, 403);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Edit/Update";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // Student_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.guardianContactLabel);
            this.Controls.Add(this.guardianLabel);
            this.Controls.Add(this.courseYearLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.changeImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.profilePictureBox);
            this.Name = "Student_Page";
            this.Text = "Student_Page";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button changeImageButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label courseYearLabel;
        private System.Windows.Forms.Label guardianLabel;
        private System.Windows.Forms.Label guardianContactLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label hobbiesLabel;
        private System.Windows.Forms.Button editButton;
    }
}