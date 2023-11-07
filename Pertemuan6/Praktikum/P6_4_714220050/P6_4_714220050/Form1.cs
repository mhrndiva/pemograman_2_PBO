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

namespace P6_4_714220050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxNama_Leave(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                epWarning.SetError(textBoxNama, "Textbox nama tidak boleh kosong!");
                epCorrect.SetError(textBoxNama, "");
                epWrong.SetError(textBoxNama, "");
            }
            else
            {
                if ((textBoxNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBoxNama, "");
                    epWrong.SetError(textBoxNama, "");
                    epCorrect.SetError(textBoxNama, "Betul");
                }
                else
                {
                    epCorrect.SetError(textBoxNama, "");
                    epWarning.SetError(textBoxNama, "");
                    epWrong.SetError(textBoxNama, "Inputan hanya boleh huruf!");
                }
            }
        }

        private void textBoxNomorHP_Leave(object sender, EventArgs e)
        {
            if (textBoxNomorHP.Text == "")
            {
                epWarning.SetError(textBoxNomorHP, "Textbox nomor HP tidak boleh kosong!");
                epCorrect.SetError(textBoxNomorHP, "");
                epWrong.SetError(textBoxNomorHP, "");
            }
            else
            {
                if ((textBoxNomorHP.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textBoxNomorHP, "Betul");
                    epWarning.SetError(textBoxNomorHP, "");
                    epWrong.SetError(textBoxNomorHP, "");
                }
                else
                {
                    epCorrect.SetError(textBoxNomorHP, "");
                    epWarning.SetError(textBoxNomorHP, "");
                    epWrong.SetError(textBoxNomorHP, "Inputan hanya boleh Angka!");
                }
            }
        }

        private void textBoxJenisKamar_Leave(object sender, EventArgs e)
        {
            if (textBoxJenisKamar.Text == "")
            {
                epWarning.SetError(textBoxJenisKamar, "Textbox Kamar tidak boleh kosong!");
                epCorrect.SetError(textBoxJenisKamar, "");
                epWrong.SetError(textBoxJenisKamar, "");
            }
            else
            {
                if ((textBoxJenisKamar.Text).All(Char.IsLetter))
                {
                    epCorrect.SetError(textBoxJenisKamar, "Betul");
                    epWarning.SetError(textBoxJenisKamar, "");
                    epWrong.SetError(textBoxJenisKamar, "");
                }
                else
                {
                    epCorrect.SetError(textBoxJenisKamar, "");
                    epWarning.SetError(textBoxJenisKamar, "");
                    epWrong.SetError(textBoxJenisKamar, "Inputan hanya boleh huruf!");
                }
            }
        }

        private void textBoxJenisKamar_Click(object sender, EventArgs e)
        {

        }

        private void buttonReservasi_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string nomorHP = textBoxNomorHP.Text;
            DateTime checkInDate = dateTimePickerCheckIn.Value;
            DateTime checkOutDate = dateTimePickerCheckOut.Value;
            string jenisKamar = textBoxJenisKamar.Text;

            string errorMessage = "";

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(nomorHP) || string.IsNullOrEmpty(jenisKamar))
            {
                errorMessage = "Semua field harus diisi.";
            }
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
                MessageBox.Show(
                "Nama: " + nama + "\n"+
                "Nomor HP: " + nomorHP + "\n"+
                "Tanggal Check-In: " + checkInDate.ToString("dd/MM/yyyy") + "\n"+
                "Tanggal Check-Out: " + checkOutDate.ToString("dd/MM/yyyy") + "\n"+
                "Jenis Kamar: " + jenisKamar);
      
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            textBoxNama.Text = textBoxNama.Text;
            string input = textBoxNama.Text;

            if (!string.IsNullOrEmpty(input))
            {
                input = char.ToUpper(input[0]) + input.Substring(1).ToLower();

                textBoxNama.Text = input;

                textBoxNama.SelectionStart = input.Length;
            }
        }
    }

    }

