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

            dtDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtDateOfBirth.MinDate = DateTime.Today.AddYears(-100);

            dtDateOfBirth.Value = dtDateOfBirth.MaxDate;
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

            }catch(Exception ex)
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
    }
}
