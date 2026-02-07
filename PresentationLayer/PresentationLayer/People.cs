using BusinessLayer;
using System.Data;

namespace PresentationLayer
{
    public partial class People : Form
    {
        private DataTable _dt = clsPeople.GetPeopleData();

        public People()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> GetColumnMapping()
        {

            return new Dictionary<string, string>()
            {
                { "National No", "NationalNo" },
                { "First Name", "FirstName" },
                { "Second Name", "SecondName" },
                { "Third Name", "ThirdName" },
                { "Last Name", "LastName" },
                { "Date Of Birth", "DateOfBirth" },
                { "Gender", "Gender" },
                { "Address", "Address" },
                { "Phone", "Phone" },
                { "Email", "Email" },
                { "Country Name", "CountryName" },
                { "Image Path", "ImagePath" }
            };
        }

        private void People_Load(object sender, EventArgs e)
        {
            lvPeople.FullRowSelect = true;

            lvPeople.View = View.Details;

            lvPeople.Columns.Add("National No", 100);
            lvPeople.Columns.Add("First Name", 100);
            lvPeople.Columns.Add("Second Name", 100);
            lvPeople.Columns.Add("Third Name", 100);
            lvPeople.Columns.Add("Last Name", 100);
            lvPeople.Columns.Add("Date Of Birth", 100);
            lvPeople.Columns.Add("Gender", 60);
            lvPeople.Columns.Add("Address", 200);
            lvPeople.Columns.Add("Phone", 100);
            lvPeople.Columns.Add("Email", 150);
            lvPeople.Columns.Add("Country Name", 120);
            lvPeople.Columns.Add("Image Path", 110);

            Dictionary<string, string> ColumnMapping = GetColumnMapping();

            cbFilterBy.Items.Insert(0, "Select A Filter...");
            cbFilterBy.SelectedIndex = 0;
            foreach (var item in ColumnMapping)
            {
                cbFilterBy.Items.Add(item.Key);
            }

            LoadPeopleData(_dt);
        }

        private void LoadPeopleData(DataTable dt)
        {
            lvPeople.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {

                ListViewItem item = new ListViewItem(row["NationalNo"].ToString());
                item.SubItems.Add(row["FirstName"].ToString());
                item.SubItems.Add(row["SecondName"].ToString());
                item.SubItems.Add(row["ThirdName"].ToString());
                item.SubItems.Add(row["LastName"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["DateOfBirth"]).ToString("MM/dd/yyyy"));
                item.SubItems.Add(row["Gender"].ToString());
                item.SubItems.Add(row["Address"].ToString());
                item.SubItems.Add(row["Phone"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["CountryName"].ToString());
                item.SubItems.Add(row["ImagePath"].ToString());

                lvPeople.Items.Add(item);
            }

            lblCountRecords.Text = $"# Records: {lvPeople.Items.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                return;
            }

            Dictionary<string, string> ColumnMapping = GetColumnMapping();

            string DisplayName = (string)cbFilterBy.SelectedItem!;
            string dbColumnName = ColumnMapping[DisplayName];

            DataView dv = _dt.DefaultView;
            dv.Sort = dbColumnName + " ASC";

            LoadPeopleData(dv.ToTable());
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {

        }
    }
}