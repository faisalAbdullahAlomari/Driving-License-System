using DataAccessLayer;
using System.Data;
using System.Runtime.CompilerServices;

namespace BusinessLayer
{
    public class clsPeople
    {

        private bool _AddNewPerson()
        {
            this.PersonID =  clsPeopleData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender,
                    this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            bool UpdatedSuccessfully = clsPeopleData.UpdatePersonInfo(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address,
                this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return UpdatedSuccessfully;
        }

        public enum enPageMode { AddNewPerson = 1, UpdatePerson = 2}

        public enPageMode enPage = enPageMode.AddNewPerson;

        public int PersonID { set; get; }
        public string NationalNo { set; get; } = string.Empty;
        public string FirstName { set; get; } = string.Empty;
        public string SecondName { set; get; } = string.Empty;
        public string ThirdName { set; get; } = string.Empty;
        public string LastName { set; get; } = string.Empty;
        public DateTime DateOfBirth { set; get; }
        public bool Gender { set; get; }
        public string Address { set; get; } = string.Empty;
        public string Phone { set; get; } = string.Empty;
        public string Email { set; get; } = string.Empty;
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; } = string.Empty;

        public clsPeople(){

            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = true;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

        }

        private clsPeople(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastNamem, 
                        DateTime DateOfBirth, bool Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            enPageMode enPage = enPageMode.UpdatePerson;
        }


        public static DataTable GetPeopleData()
        {
            DataTable dt = new DataTable();

            dt = clsPeopleData.GetPeopleData();

            return dt;
        }

        public static bool NationalNumberExists(string NationalNumber)
        {
            return clsPeopleData.NationalNumberExists(NationalNumber);
        }

        public static DataTable LoadCountries()
        {
            return clsPeopleData.LoadAllCountries();
        }

        public bool Save()
        {
            switch (enPage)
            {
                case enPageMode.AddNewPerson:
                    if (_AddNewPerson())
                    {
                        enPage = enPageMode.UpdatePerson;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enPageMode.UpdatePerson:
                    return _UpdatePerson();

                default:
                    return false;
            }
        } 
    }
}
