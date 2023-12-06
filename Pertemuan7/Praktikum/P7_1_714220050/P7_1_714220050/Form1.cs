using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(456, 233);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }


            if (string.IsNullOrWhiteSpace(textBoxProdi.Text))
            {
                errorMessage += "Prodi belum diisi\n";
            }else if (!Regex.IsMatch(textBoxProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage += "Kelas belum diisi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                this.Size = new Size(456, 446);
            }
            else
            {
                MessageBox.Show(
                    errorMessage,
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSenin.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTravelling.Enabled = false; cbTravelling.Checked = false;
                cbTidur.Enabled = true; cbTidur.Checked = false;
            }
        }
        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinggu.Checked)
            {
                cbKuliah.Enabled = false;
                cbTravelling.Enabled = true;
                cbTidur.Enabled = true;
            }
        }

        private void buttonTPesan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRForm_Click(object sender, EventArgs e)
        {
            //textBoxNama.Text = null;
            //textBoxProdi.Text = null;
            //textBoxKelas.Text = null;

            //mereset semua form menggunakan looping
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }
            this.Size = new Size(456, 233);
        }
    }
}
