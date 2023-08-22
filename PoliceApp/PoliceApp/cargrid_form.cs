using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceApp
{
    public partial class cargrid_form : Form
    {
        public cargrid_form()
        {
            InitializeComponent();
        }

        private void cargrid_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'police_dbDataSet3.Cars_tb' table. You can move, or remove it, as needed.
            this.cars_tbTableAdapter2.Fill(this.police_dbDataSet3.Cars_tb);
            // TODO: This line of code loads data into the 'police_dbDataSet.Locations_tb' table. You can move, or remove it, as needed.
            this.locations_tbTableAdapter.Fill(this.police_dbDataSet.Locations_tb);
            // TODO: This line of code loads data into the 'police_dbDataSet2.Cars_tb' table. You can move, or remove it, as needed.
            this.cars_tbTableAdapter1.Fill(this.police_dbDataSet2.Cars_tb);
            // TODO: This line of code loads data into the 'police_dbDataSet1.Cars_tb' table. You can move, or remove it, as needed.
            this.cars_tbTableAdapter.Fill(this.police_dbDataSet1.Cars_tb);

        }

        private void driverIdTb_TextChanged(object sender, EventArgs e)
        {
            //if (fineNumTb.Text != "")
            //{
            //    transportNumTb.Enabled = false;
            //    driverIdTb.Enabled = false;
            //    driverNameTb.Enabled = false;
            //    driverLastnameTb.Enabled = false;
            //    cityCbx.Enabled = false;
            //}
            //else
            //{
            //    transportNumTb.Enabled = true;
            //    driverIdTb.Enabled = true;
            //    driverNameTb.Enabled = true;
            //    driverLastnameTb.Enabled = true;
            //    cityCbx.Enabled = true;
            //}
        }
    }
}
