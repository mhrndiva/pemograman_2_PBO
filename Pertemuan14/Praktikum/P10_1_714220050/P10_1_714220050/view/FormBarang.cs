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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P10_1_714220050.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_brg = new M_barang();
        string id_barang;
        public FormBarang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Tampil()
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");
            DataBarang.Columns[0].HeaderText = "Id Barang";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void ResetForm()
        {
            nama_barang.Text = "";
            harga.Text = "";
            tb_cari.Text = "";
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (nama_barang.Text == "" || (nama_barang.Text).All(Char.IsNumber) || harga.Text == "" || (harga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Isi data dengan benar sebelum dimasukkan!", "Terjadi Kesalahan Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                barang barang = new barang();
                m_brg.Nama_barang = nama_barang.Text;
                m_brg.Harga = harga.Text;

                barang.Insert(m_brg);
                ResetForm();
                Tampil();
            }
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_barang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            harga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (nama_barang.Text != "" || !nama_barang.Text.All(Char.IsNumber) || harga.Text != "" || !harga.Text.All(Char.IsLetter))
            {
                barang barang = new barang();
                m_brg.Nama_barang = nama_barang.Text;
                m_brg.Harga = harga.Text;

                barang.Update(m_brg, id_barang);
                ResetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                barang barang = new barang();
                barang.Delete(id_barang);
                ResetForm();
                Tampil();
            }
        }

        private void tb_cari_TextChanged(object sender, EventArgs e)
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + tb_cari.Text + "' '%' OR nama_barang LIKE '%' '" + tb_cari.Text + "' '%' OR harga LIKE '%' '" + tb_cari.Text + "' '%'");
        }

        private void DataBarang_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void DataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        private void DataBarang_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (DataBarang.Columns[e.ColumnIndex].Name == "Harga")
            {
                string newValue = e.FormattedValue.ToString();

                // Hapus karakter selain angka dari nilai yang dimasukkan
                newValue = new string(newValue.Where(c => char.IsDigit(c)).ToArray());

                // Ubah ke dalam format desimal
                if (decimal.TryParse(newValue, out decimal parsedValue))
                {
                    DataBarang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = parsedValue;
                }
                else
                {
                    e.Cancel = true;
                }
        }
        }

       private void btn_refresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void DataBarang_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && DataBarang.Columns[e.ColumnIndex].Name == "Harga")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    // Konversi nilai ke tipe data decimal
                    decimal harga = (decimal)e.Value;

                    // Ganti teks yang akan ditampilkan di sel dengan format Rupiah tanpa desimal
                    e.PaintBackground(e.CellBounds, true);
                    e.PaintContent(e.CellBounds);

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Near;
                        sf.LineAlignment = StringAlignment.Center;

                        string formattedValue = string.Format(CultureInfo.GetCultureInfo("id-ID"), "Rp {0:#,0}", harga);
                        e.Graphics.DrawString(formattedValue, e.CellStyle.Font, Brushes.Black, e.CellBounds, sf);
                    }

                    e.Handled = true;
                }
        }
        }
    }
}
