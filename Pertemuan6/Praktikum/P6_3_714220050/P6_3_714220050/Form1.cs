using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220050
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if ((txtAngka.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(txtAngka, "Betul!");
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
            }
            else
            {
                epCorrect.SetError(txtAngka, "");
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "Inputan hanya boleh angka");
            }
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if ((txtHuruf.Text).All(Char.IsLetter))
            {
                epWarning.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "Betul!");
            }
            else
            {
                epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                epWarning.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
        }

        private void Huruf(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngka1.Text, out int angka1) && int.TryParse(txtAngka2.Text, out int angka2))
                if (angka1 > angka2)
                {
                    epCorrect.SetError(txtAngka1, "Betul!");
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Angka1 harus lebih besar dari Angka2.");
                }
            else
            {
                epCorrect.SetError(txtAngka1, "");
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {
                if (int.TryParse(txtAngka1.Text, out int angka1) && int.TryParse(txtAngka2.Text, out int angka2))
                {
                    if (angka1 > angka2)
                    {
                        epCorrect.SetError(txtAngka2, "Betul!");
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "");
                    }
                    else
                    {
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "Angka2 harus lebih kecil dari Angka1.");
                    }
                }
                else
                {
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                }
        }
    }
}
