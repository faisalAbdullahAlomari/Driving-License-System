using BusinessLayer;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
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
            lvPeople.Columns.Add("Nationality Country ID", 80);
            lvPeople.Columns.Add("Image Path", 150);

            LoadPeopleData();
        }

        private void LoadPeopleData()
        {
            DataTable dt = clsPeople.GetPeopleData();

            lvPeople.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {

                ListViewItem item = new ListViewItem(row["NationalNo"].ToString());
                item.SubItems.Add(row["FirstName"].ToString());
                item.SubItems.Add(row["SecondName"].ToString());
                item.SubItems.Add(row["ThirdName"].ToString());
                item.SubItems.Add(row["LastName"].ToString());
                item.SubItems.Add(row["DateOfBirth"].ToString());
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
    }
}
