using MySql.Data.MySqlClient;
using P10_1_714220050.controller;
using P10_1_714220050.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220050.view
{
    public partial class FromTransaksiBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_transaksi_barang transaksi = new M_transaksi_barang();
        M_barang m_barang = new M_barang();
        string id_transaksi;
        public FromTransaksiBarang()
        {
            InitializeComponent();

            comboBox1.IsAccessible = true;
            comboBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox2.ReadOnly = true;
            textBox4.Enabled = false;
            textBox4.ReadOnly = true;

            LoadIdBarang();
        }



        public void Tampil()
        {
            DataTransaksiBarang.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang)");
            DataTransaksiBarang.Columns[0].HeaderText = "ID";
            DataTransaksiBarang.Columns[1].HeaderText = "ID Barang";
            DataTransaksiBarang.Columns[2].HeaderText = "Nama Barang";
            DataTransaksiBarang.Columns[3].HeaderText = "Harga";
            DataTransaksiBarang.Columns[4].HeaderText = "QTY";
            DataTransaksiBarang.Columns[5].HeaderText = "Total Harga";
        }

        public void ResetForm()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        public void LoadIdBarang()
        {
            koneksi.OpenConnection();

            string query = "SELECT id_barang FROM t_barang";
            object dataTable = koneksi.ShowData(query);

            comboBox1.DisplayMember = "id_barang";
            comboBox1.ValueMember = "id_barang";
            comboBox1.DataSource = dataTable;

            koneksi.CloseConnection();
        }

        public void GetDataBarang(int selectIdBarang)
        {
            koneksi.OpenConnection();

            string query = $"SELECT nama_barang, harga FROM t_barang WHERE id_barang = {selectIdBarang}";
            MySqlDataReader reader = koneksi.reader(query);

            if (reader.Read())
            {
                textBox1.Text = reader["nama_barang"].ToString();
                textBox2.Text = reader["harga"].ToString();
            }

            reader.Close();
            koneksi.CloseConnection();
        }

        private void TotalHarga()
        {
            if (double.TryParse(textBox3.Text, out double qty_barang) && double.TryParse(textBox2.Text.Replace(".", ""), out double harga))
            {
                double totals = qty_barang * harga;

                string formattedTotal = string.Format("{0:#,##0}", totals);

                textBox4.Text = formattedTotal;
            }
        }


        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        private void FormatDigit(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.Text.All(char.IsDigit))
            {
                string number = textBox.Text.Replace(".", "");

                number = string.Format("{0:#,##0}", double.Parse(number));

                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void FromTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int selectIdBarang;
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out selectIdBarang))
                {
                    GetDataBarang(selectIdBarang);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text.Any(Char.IsLetter) || textBox3.Text.Any(Char.IsLetter) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Isi form dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransaksiBarang tr_brg = new TransaksiBarang();
                transaksi.Id_barang = comboBox1.Text;
                transaksi.Qty = textBox3.Text;

                string formattedTotal = textBox4.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    transaksi.Total = numericTotal.ToString();
                }

                tr_brg.Insert(transaksi);
                ResetForm();
                Tampil();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" || textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || !comboBox1.Text.Any(Char.IsLetter) || !textBox3.Text.Any(Char.IsLetter) || comboBox1.SelectedItem != null)
            {
                TransaksiBarang tr_brg = new TransaksiBarang();
                transaksi.Id_barang = comboBox1.Text;
                transaksi.Qty = textBox3.Text;


                string formattedTotal = textBox4.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    transaksi.Total = numericTotal.ToString();
                }

                tr_brg.Update(transaksi, id_transaksi);
                ResetForm();
                Tampil();
            }

            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FormatDigit(textBox2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void DataTransaksiBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void DataTransaksiBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            id_transaksi = DataTransaksiBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox1.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[4].Value.ToString();

            TotalHarga();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataTransaksiBarang.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang) WHERE id_transaksi LIKE '%' '" + textBox5.Text + "' '%' OR t.id_barang LIKE '%' '" + textBox5.Text + "' '%' OR b.id_barang LIKE '%' '" + textBox5.Text + "' '%' OR nama_barang LIKE '%' '" + textBox5.Text + "' '%' OR harga LIKE '%' '" + textBox5.Text + "' '%' OR qty LIKE '%' '" + textBox5.Text + "' '%' OR total LIKE '%' '" + textBox5.Text + "' '%'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                TransaksiBarang tr_brg = new TransaksiBarang();
                tr_brg.Delete(id_transaksi);
                ResetForm();
                Tampil();
            }
        }
    }
    }






