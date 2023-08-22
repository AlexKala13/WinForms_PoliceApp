using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PoliceApp
{
    public partial class grid_form : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public static string query = "";

        public grid_form()
        {
            InitializeComponent();
        }

        private void grid_form_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'police_dbDataSet.Locations_tb' table. You can move, or remove it, as needed.
            this.locations_tbTableAdapter.Fill(this.police_dbDataSet.Locations_tb);

        }

        //private void transportNumTb_TextChanged(object sender, System.EventArgs e)
        //{
        //    if (transportNumTb.Text != "")
        //    {
        //        driverIdTb.Enabled = false;
        //        fineNumTb.Enabled = false;
        //        driverNameTb.Enabled = false;
        //        driverLastnameTb.Enabled = false;
        //        cityCbx.Enabled = false;
        //    }
        //    else
        //    {
        //        driverIdTb.Enabled = true;
        //        fineNumTb.Enabled = true;
        //        driverNameTb.Enabled = true;
        //        driverLastnameTb.Enabled = true;
        //        cityCbx.Enabled = true;
        //    }
        //}

        private void driverIdTb_TextChanged(object sender, System.EventArgs e)
        {
            if (driverIdTb.Text != "")
            {
                driverNameTb.Enabled = false;
                driverLastnameTb.Enabled = false;
                cityCbx.Enabled = false;
            }
            else
            {
                driverNameTb.Enabled = true;
                driverLastnameTb.Enabled = true;
                cityCbx.Enabled = true;
            }
        }

        //private void fineNumTb_TextChanged(object sender, System.EventArgs e)
        //{
        //    if (fineNumTb.Text != "")
        //    {
        //        transportNumTb.Enabled = false;
        //        driverIdTb.Enabled = false;
        //        driverNameTb.Enabled = false;
        //        driverLastnameTb.Enabled = false;
        //        cityCbx.Enabled = false;
        //    }
        //    else
        //    {
        //        transportNumTb.Enabled = true;
        //        driverIdTb.Enabled = true;
        //        driverNameTb.Enabled = true;
        //        driverLastnameTb.Enabled = true;
        //        cityCbx.Enabled = true;
        //    }
        //}

        private void searchBtn_Click(object sender, System.EventArgs e)
        {
            policeDataGridView.AutoGenerateColumns = true;
            policeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H7EVQ59\SQLEXPRESS;Initial Catalog=Police_db;Integrated Security=True");

            if (driverIdTb.Text != "")
            {
                query = "SELECT * FROM Drivers_tb WHERE DriverID = '" + driverIdTb.Text + "'";
            }
            else if (driverNameTb.Text != "" && driverLastnameTb.Text != "")
            {
                query = "SELECT * FROM Drivers_tb WHERE FirstName ='" + driverNameTb.Text + "' AND LastName ='" + driverLastnameTb.Text + "'";
            }
            else if (driverNameTb.Text != "" || driverLastnameTb.Text != "")
            {
                query = "SELECT * FROM Drivers_tb WHERE FirstName ='" + driverNameTb.Text + "' OR LastName ='" + driverLastnameTb.Text + "'";
            }
            else 
            {
                MessageBox.Show("Sheiyvanet monacemebi!");
            }

            if(query != "")
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);

                table = new DataTable();

                adapter.Fill(table);
                policeDataGridView.DataSource = table;

                sqlConnection.Close();
            }
        }

        private void cleanBtn_Click(object sender, System.EventArgs e)
        {
            policeDataGridView.DataSource = null;
            driverIdTb.Clear();     
            driverNameTb.Clear();
            driverLastnameTb.Clear();
        }

        private void policeDataGridView_DoubleClick(object sender, System.EventArgs e)
        {
            detailedInfo_form detailedinfo = new detailedInfo_form();
            detailedinfo.Show();
        }
    }
}
