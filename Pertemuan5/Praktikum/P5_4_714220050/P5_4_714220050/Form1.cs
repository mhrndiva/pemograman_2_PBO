using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string label2 = CB_Kelamin.SelectedItem.ToString();
            DateTime label3 = waktu.Value;


            string kelas = "";
            string jadwal = "";

            if (checkBox1.Checked)
            {
                kelas += "Biola ";
            }
            if (checkBox2.Checked)
            {
                kelas += "Gitar ";
            }
            if (checkBox3.Checked)
            {
                kelas += "Saxophone ";
            }
            if (checkBox4.Checked)
            {
                kelas += "Konduktor ";
            }
            if (checkBox5.Checked)
            {
                kelas += "Piano ";
            }
            if (checkBox6.Checked)
            {
                kelas += "Drum ";
            }
            if (checkBox7.Checked)
            {
                kelas += "Vokal ";
            }
            if (checkBox8.Checked)
            {
                kelas += "Komposer ";
            }
            else if (string.IsNullOrEmpty(kelas))
            {
                MessageBox.Show("Anda haru memilih kelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (radioButton1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.0";
            }
            else if (radioButton2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (radioButton3.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }


            MessageBox.Show(
                "Nama: " + textNama.Text +
                "\nJenis Kelamin: " + label2 +
                "\nTanggal Lahir:" + label3.ToString("dd MMMM yyyy") +
                "\nPilihan Kelas: " + kelas +
                "\nPilihan Jadwal: " + jadwal, 
                "Informasi Pendataran",
                MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
