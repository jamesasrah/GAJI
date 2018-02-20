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
            this.Validate();
            this.daftarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payrollDataSet);
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

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime timeOfDay = DateTime.Now;
            txtReceipt.Text = "";
            txtReceipt.AppendText("" + Environment.NewLine);
            txtReceipt.AppendText("\t\t\t\tSlip Gaji" + Environment.NewLine);
            txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =" + Environment.NewLine);
            txtReceipt.AppendText("\t\t\t\t Welcome" + Environment.NewLine);
            txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = \n");
            txtReceipt.AppendText(Environment.NewLine);
            txtReceipt.AppendText("Nama pegawai " + "\t" + employee_NameTextBox.Text + "\t\t\t" + employerTextBox.Text + Environment.NewLine);
            txtReceipt.AppendText("Alamat: " + "\t" + address1TextBox.Text + Environment.NewLine);
            txtReceipt.AppendText("kodepos: " + "\t" + postCodeTextBox.Text + Environment.NewLine);
            txtReceipt.AppendText(" " + Environment.NewLine);
            txtReceipt.AppendText("Employer Name: " + "\t" + employerTextBox.Text + "\t\t\t" + "tanggal bayar: " + "\t\t" + paydateDateTimePicker.Text + Environment.NewLine);
            txtReceipt.AppendText("employee Name: " + "\t" + employee_NameTextBox.Text + "\t\t\t" + "pajak Period: " + "\t" + tax_PeriodTextBox + Environment.NewLine);
            txtReceipt.AppendText("reference No.: " + "\t" + reference_NoTextBox.Text + "\t\t\t\t" + "nomor pajak: " + "\t" + tax_CodeTextBox.Text + Environment.NewLine);
            txtReceipt.AppendText("\t\t\t\t\t\t" + "N.I");

        }
    }
}
