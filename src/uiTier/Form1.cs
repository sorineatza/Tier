using System;
using System.Windows.Forms;
using blTier;
using System.Data.SqlClient;

namespace uiTier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                PersonBLL p = new PersonBLL();
                this.dataGridView1.DataSource = p.GetPersons(Convert.ToInt16(this.txtID.Text));
            }
            catch
            {
                MessageBox.Show("Error Occurred Get Persons");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                PersonBLL p = new PersonBLL();
                this.dataGridView1.DataSource = p.GetPersons();
            }
            catch
            {
                MessageBox.Show("Error Occurred Form Load");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string StrQuery;
            //MessageBox.Show("Update Persons");

            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    StrQuery = @"update Person set  Name='" + dataGridView1.Rows[i].Cells["Name"].Value.ToString() + "',Surname='" + dataGridView1.Rows[i].Cells["Surname"].Value.ToString() + "' where ID='" + dataGridView1.Rows[i].Cells["ID"].Value.ToString() + "';";
                    PersonBLL p = new PersonBLL();
                    p.UpdateGrid(StrQuery);
                }

            }
            catch
            {
                MessageBox.Show("Error Occurred Grid Update");
            }

        }
    }
}
