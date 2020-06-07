using System;
using System.Windows.Forms;
using blTier;

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


    }
}
