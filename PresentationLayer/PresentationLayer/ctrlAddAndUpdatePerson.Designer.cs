namespace PresentationLayer
{
    partial class ctrlAddAndUpdatePerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddAndUpdatePerson));
            txtFirstName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSecondName = new TextBox();
            label5 = new Label();
            txtThirdName = new TextBox();
            label6 = new Label();
            txtLastName = new TextBox();
            pbPersonPicture = new PictureBox();
            label2 = new Label();
            txtNationalNumber = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtPhone = new TextBox();
            label12 = new Label();
            btnSetImage = new Button();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            dtDateOfBirth = new DateTimePicker();
            cbCountries = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbPersonPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(170, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 54);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 10);
            label1.Size = new Size(60, 31);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(221, 18);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 10);
            label3.Size = new Size(41, 31);
            label3.TabIndex = 3;
            label3.Text = "First";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(387, 18);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 10);
            label4.Size = new Size(65, 31);
            label4.TabIndex = 5;
            label4.Text = "Second";
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(336, 52);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(160, 23);
            txtSecondName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(553, 18);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 10);
            label5.Size = new Size(48, 31);
            label5.TabIndex = 7;
            label5.Text = "Third";
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(502, 52);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(160, 23);
            txtThirdName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(719, 18);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 10);
            label6.Size = new Size(39, 31);
            label6.TabIndex = 9;
            label6.Text = "Last";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(668, 52);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(160, 23);
            txtLastName.TabIndex = 4;
            // 
            // pbPersonPicture
            // 
            pbPersonPicture.AccessibleRole = AccessibleRole.Clock;
            pbPersonPicture.Image = (Image)resources.GetObject("pbPersonPicture.Image");
            pbPersonPicture.Location = new Point(668, 92);
            pbPersonPicture.Name = "pbPersonPicture";
            pbPersonPicture.Size = new Size(160, 155);
            pbPersonPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonPicture.TabIndex = 10;
            pbPersonPicture.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 104);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 10);
            label2.Size = new Size(149, 31);
            label2.TabIndex = 12;
            label2.Text = "National Number:";
            // 
            // txtNationalNumber
            // 
            txtNationalNumber.Location = new Point(170, 102);
            txtNationalNumber.Name = "txtNationalNumber";
            txtNationalNumber.Size = new Size(160, 23);
            txtNationalNumber.TabIndex = 5;
            txtNationalNumber.Validating += txtNationalNumber_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 154);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 10);
            label7.Size = new Size(70, 31);
            label7.TabIndex = 14;
            label7.Text = "Gender:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 204);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 0, 10);
            label8.Size = new Size(57, 31);
            label8.TabIndex = 16;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 23);
            txtEmail.TabIndex = 10;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 254);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 0, 10);
            label9.Size = new Size(74, 31);
            label9.TabIndex = 18;
            label9.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(170, 252);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(492, 106);
            txtAddress.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(383, 104);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 0, 0, 10);
            label10.Size = new Size(113, 31);
            label10.TabIndex = 20;
            label10.Text = "Date Of Birth:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(433, 150);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 0, 0, 10);
            label11.Size = new Size(63, 31);
            label11.TabIndex = 22;
            label11.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(502, 152);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(160, 23);
            txtPhone.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(420, 200);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 0, 0, 10);
            label12.Size = new Size(76, 31);
            label12.TabIndex = 24;
            label12.Text = "Country:";
            // 
            // btnSetImage
            // 
            btnSetImage.FlatAppearance.BorderSize = 0;
            btnSetImage.FlatStyle = FlatStyle.Flat;
            btnSetImage.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSetImage.ForeColor = SystemColors.HotTrack;
            btnSetImage.Location = new Point(708, 252);
            btnSetImage.Name = "btnSetImage";
            btnSetImage.Size = new Size(80, 32);
            btnSetImage.TabIndex = 13;
            btnSetImage.Text = "Set Image";
            btnSetImage.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(180, 152);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 7;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(257, 152);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 8;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.Format = DateTimePickerFormat.Short;
            dtDateOfBirth.Location = new Point(502, 102);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(160, 23);
            dtDateOfBirth.TabIndex = 6;
            // 
            // cbCountries
            // 
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(502, 202);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(160, 23);
            cbCountries.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlAddAndUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbCountries);
            Controls.Add(dtDateOfBirth);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(btnSetImage);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtPhone);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtNationalNumber);
            Controls.Add(pbPersonPicture);
            Controls.Add(label6);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(txtThirdName);
            Controls.Add(label4);
            Controls.Add(txtSecondName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Name = "ctrlAddAndUpdatePerson";
            Size = new Size(842, 405);
            ((System.ComponentModel.ISupportInitialize)pbPersonPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtSecondName;
        private Label label5;
        private TextBox txtThirdName;
        private Label label6;
        private TextBox txtLastName;
        private PictureBox pbPersonPicture;
        private Label label2;
        private TextBox txtNationalNumber;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtAddress;
        private Label label10;
        private Label label11;
        private TextBox txtPhone;
        private Label label12;
        private Button btnSetImage;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private DateTimePicker dtDateOfBirth;
        private ComboBox cbCountries;
        private ErrorProvider errorProvider1;
    }
}
