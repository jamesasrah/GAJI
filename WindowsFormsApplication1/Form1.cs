using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daftarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.daftarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payrollDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollDataSet.daftar' table. You can move, or remove it, as needed.
            this.daftarTableAdapter.Fill(this.payrollDataSet.daftar);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            daftarBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daftarBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            daftarBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            daftarBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
