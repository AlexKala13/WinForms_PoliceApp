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
    public partial class selector_form : Form
    {
        public selector_form()
        {
            InitializeComponent();
        }

        private void driversBtn_Click(object sender, EventArgs e)
        {
            grid_form grid_Form = new grid_form();
            grid_Form.Show();
            this.Close();
        }
    }
}
