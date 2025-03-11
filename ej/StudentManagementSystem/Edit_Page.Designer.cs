namespace StudentSystem
{
    partial class Edit_Page
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.TextBox guardianTextBox;
        private System.Windows.Forms.TextBox guardianContactTextBox;
        private System.Windows.Forms.TextBox hobbiesTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Button saveButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.guardianTextBox = new System.Windows.Forms.TextBox();
            this.guardianContactTextBox = new System.Windows.Forms.TextBox();
            this.hobbiesTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(100, 50);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 20);
            this.ageTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(100, 80);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(100, 110);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(100, 140);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // courseComboBox
            // 
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(100, 170);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(200, 21);
            this.courseComboBox.TabIndex = 5;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(100, 200);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(200, 21);
            this.yearComboBox.TabIndex = 6;
            // 
            // guardianTextBox
            // 
            this.guardianTextBox.Location = new System.Drawing.Point(100, 230);
            this.guardianTextBox.Name = "guardianTextBox";
            this.guardianTextBox.Size = new System.Drawing.Size(200, 20);
            this.guardianTextBox.TabIndex = 7;
            // 
            // guardianContactTextBox
            // 
            this.guardianContactTextBox.Location = new System.Drawing.Point(100, 260);
            this.guardianContactTextBox.Name = "guardianContactTextBox";
            this.guardianContactTextBox.Size = new System.Drawing.Size(200, 20);
            this.guardianContactTextBox.TabIndex = 8;
            // 
            // hobbiesTextBox
            // 
            this.hobbiesTextBox.Location = new System.Drawing.Point(100, 290);
            this.hobbiesTextBox.Name = "hobbiesTextBox";
            this.hobbiesTextBox.Size = new System.Drawing.Size(200, 20);
            this.hobbiesTextBox.TabIndex = 9;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(100, 320);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nicknameTextBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(100, 350);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Edit_Page
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.hobbiesTextBox);
            this.Controls.Add(this.guardianContactTextBox);
            this.Controls.Add(this.guardianTextBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Edit_Page";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}