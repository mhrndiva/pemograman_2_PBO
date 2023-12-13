using P10_1_714220050.controller;
using P10_1_714220050.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P10_1_714220050
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        public Form1()
        {
            InitializeComponent();
        }

        public void RefreshForm()
        {
            ResetForm();
        }
        public void ResetForm()
        {
            npm.Text = "";
            nama.Text = "";
            angkatan.SelectedIndex = -1;
            alamat.Text = "";
            email.Text = "";
            nohp.Text = "";
        }

        public void Tampil()
        {
            //Query DB Get MGS
            DataMahasiswa.DataSource = koneksi.ShowData("Select * from t_mahasiswa");

            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 ||alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.Insert(m_mhs);
                ResetForm();
                Tampil();
            }

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            npm.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            angkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            alamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            email.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            nohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 || alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.Update(m_mhs, npm.Text);

                ResetForm();
                Tampil();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(npm.Text);
                ResetForm();
                Tampil();
            }
        }
    }
}
