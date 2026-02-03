using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class clsPeople
    {
        public static DataTable GetPeopleData()
        {
            DataTable dt = new DataTable();

            dt = clsPeopleData.GetPeopleData();

            return dt;
        }
    }
}
