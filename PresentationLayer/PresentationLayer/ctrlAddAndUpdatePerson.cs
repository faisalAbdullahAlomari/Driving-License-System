using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using Microsoft.Identity.Client.Utils;
using System.Text.RegularExpressions;

namespace PresentationLayer
{
    public partial class ctrlAddAndUpdatePerson : UserControl
    {
        public ctrlAddAndUpdatePerson()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            {
                return;
            }

            dtDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
                dtDateOfBirth.MinDate = DateTime.Today.AddYears(-100);

                LoadCountries();

                dtDateOfBirth.Value = dtDateOfBirth.MaxDate;
                DefaultPersonPicture();
        }

        private void LoadCountries()
        {
            DataTable dtCountries = clsPeople.LoadCountries();

            cbCountries.Items.Clear();

            DataRow row = dtCountries.NewRow();
            row["CountryID"] = -1;
            row["CountryName"] = "Select Country";
            dtCountries.Rows.InsertAt(row, 0);

            cbCountries.DataSource = dtCountries;
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryID";
            cbCountries.SelectedIndex = 0;
        }

        private void DefaultPersonPicture()
        {
            if (rbMale.Checked)
            {
                pbPersonPicture.Image = Properties.Resources.user_male;
            }
            else
            {
                pbPersonPicture.Image = Properties.Resources.user_female;
            }
        }

        private void txtNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (clsPeople.NationalNumberExists(txtNationalNumber.Text))
            {
                errorProvider1.SetError(txtNationalNumber, "National Number Is Already Used");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNationalNumber, "");
                e.Cancel = false;
            }
        }

        private bool IsValidEmail(string Email)
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                return false;
            }

            try
            {

                var addr = new MailAddress(Email);

                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]{2,}$";

                return addr.Address == Email && Regex.IsMatch(Email, pattern);

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {

                errorProvider1.SetError(txtEmail, "Email Form Is Not Valid");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
                e.Cancel = false;
            }
        }

        public bool ValidateAll()
        {

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First Name Is Required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                errorProvider1.SetError(txtSecondName, "Second Name Is Required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last Name Is Required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNationalNumber.Text))
            {
                errorProvider1.SetError(txtNationalNumber, "National Number Is Required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Phone Number Is Required");
                return false;
            }

            if (cbCountries.SelectedIndex == 0)
            {
                errorProvider1.SetError(cbCountries, "Country Is Required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Address Is Required");
                return false;
            }

            errorProvider1.Clear();

            return true;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            DefaultPersonPicture();
        }
    }
}
