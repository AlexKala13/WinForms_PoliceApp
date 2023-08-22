using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PoliceApp
{
    public partial class log_form : Form
    {
        private SqlConnection sqlConnection = null;
        public log_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void log_form_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H7EVQ59\SQLEXPRESS;Initial Catalog=Police_db;Integrated Security=True");
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Officers_tb WHERE OfficerID = '" + officerTextBox.Text + "' AND OfficerPass = '"+passwordTextBox.Text+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    selector_form selectorform = new selector_form();
                    selectorform.Show();
                    this.Hide();
                }
                else
                {
                    wrongLabel.Text = "თქვენ მიერ შეყვანილი მონაცემები არასწორია!";

                    officerTextBox.Clear();
                    passwordTextBox.Clear();

                    officerTextBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void wrongLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
