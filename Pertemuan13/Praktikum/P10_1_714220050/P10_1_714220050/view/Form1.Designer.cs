namespace P10_1_714220050
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_NPM = new System.Windows.Forms.Label();
            this.label_hp = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_alamat = new System.Windows.Forms.Label();
            this.label_angkatan = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.gb_tombol = new System.Windows.Forms.GroupBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.gbdata = new System.Windows.Forms.GroupBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.angkatan = new System.Windows.Forms.ComboBox();
            this.npm = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.gbmahasiswa = new System.Windows.Forms.GroupBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.gb_tombol.SuspendLayout();
            this.gbdata.SuspendLayout();
            this.gbmahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NPM
            // 
            this.label_NPM.AutoSize = true;
            this.label_NPM.Location = new System.Drawing.Point(6, 26);
            this.label_NPM.Name = "label_NPM";
            this.label_NPM.Size = new System.Drawing.Size(31, 13);
            this.label_NPM.TabIndex = 0;
            this.label_NPM.Text = "NPM";
            this.label_NPM.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.Location = new System.Drawing.Point(6, 219);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(39, 13);
            this.label_hp.TabIndex = 2;
            this.label_hp.Text = "No HP";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(6, 183);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "Email";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // label_alamat
            // 
            this.label_alamat.AutoSize = true;
            this.label_alamat.Location = new System.Drawing.Point(6, 111);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(39, 13);
            this.label_alamat.TabIndex = 4;
            this.label_alamat.Text = "Alamat";
            // 
            // label_angkatan
            // 
            this.label_angkatan.AutoSize = true;
            this.label_angkatan.Location = new System.Drawing.Point(6, 84);
            this.label_angkatan.Name = "label_angkatan";
            this.label_angkatan.Size = new System.Drawing.Size(53, 13);
            this.label_angkatan.TabIndex = 5;
            this.label_angkatan.Text = "Angkatan";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(6, 58);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(35, 13);
            this.label_nama.TabIndex = 6;
            this.label_nama.Text = "Nama";
            // 
            // gb_tombol
            // 
            this.gb_tombol.Controls.Add(this.btn_hapus);
            this.gb_tombol.Controls.Add(this.btn_simpan);
            this.gb_tombol.Controls.Add(this.btn_ubah);
            this.gb_tombol.Controls.Add(this.btn_refresh);
            this.gb_tombol.Location = new System.Drawing.Point(505, 372);
            this.gb_tombol.Name = "gb_tombol";
            this.gb_tombol.Size = new System.Drawing.Size(283, 165);
            this.gb_tombol.TabIndex = 7;
            this.gb_tombol.TabStop = false;
            this.gb_tombol.Text = "Tombol Action";
            this.gb_tombol.Enter += new System.EventHandler(this.gb_tombol_Enter);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(6, 127);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(271, 29);
            this.btn_hapus.TabIndex = 17;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(6, 53);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(271, 33);
            this.btn_simpan.TabIndex = 15;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Location = new System.Drawing.Point(6, 90);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(271, 31);
            this.btn_ubah.TabIndex = 16;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Location = new System.Drawing.Point(6, 19);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(271, 31);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gbdata
            // 
            this.gbdata.Controls.Add(this.label_NPM);
            this.gbdata.Controls.Add(this.label_nama);
            this.gbdata.Controls.Add(this.label_angkatan);
            this.gbdata.Controls.Add(this.label_alamat);
            this.gbdata.Controls.Add(this.label_email);
            this.gbdata.Controls.Add(this.nohp);
            this.gbdata.Controls.Add(this.alamat);
            this.gbdata.Controls.Add(this.email);
            this.gbdata.Controls.Add(this.angkatan);
            this.gbdata.Controls.Add(this.label_hp);
            this.gbdata.Controls.Add(this.npm);
            this.gbdata.Controls.Add(this.nama);
            this.gbdata.Location = new System.Drawing.Point(32, 243);
            this.gbdata.Name = "gbdata";
            this.gbdata.Size = new System.Drawing.Size(456, 249);
            this.gbdata.TabIndex = 8;
            this.gbdata.TabStop = false;
            this.gbdata.Text = "Form Data Mahasiswa";
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(94, 215);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(286, 20);
            this.nohp.TabIndex = 11;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(94, 111);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(286, 57);
            this.alamat.TabIndex = 12;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(94, 183);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(286, 20);
            this.email.TabIndex = 8;
            // 
            // angkatan
            // 
            this.angkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.angkatan.FormattingEnabled = true;
            this.angkatan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.angkatan.Location = new System.Drawing.Point(94, 84);
            this.angkatan.Name = "angkatan";
            this.angkatan.Size = new System.Drawing.Size(286, 21);
            this.angkatan.TabIndex = 13;
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(94, 26);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(286, 20);
            this.npm.TabIndex = 9;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(94, 54);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(286, 20);
            this.nama.TabIndex = 10;
            // 
            // gbmahasiswa
            // 
            this.gbmahasiswa.Controls.Add(this.DataMahasiswa);
            this.gbmahasiswa.Location = new System.Drawing.Point(32, 12);
            this.gbmahasiswa.Name = "gbmahasiswa";
            this.gbmahasiswa.Size = new System.Drawing.Size(756, 215);
            this.gbmahasiswa.TabIndex = 8;
            this.gbmahasiswa.TabStop = false;
            this.gbmahasiswa.Text = "Tabel Data Mahasiswa";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(9, 19);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.Size = new System.Drawing.Size(732, 190);
            this.DataMahasiswa.TabIndex = 0;
            this.DataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(511, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Data";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(64, 53);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(198, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbdata);
            this.Controls.Add(this.gbmahasiswa);
            this.Controls.Add(this.gb_tombol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_tombol.ResumeLayout(false);
            this.gbdata.ResumeLayout(false);
            this.gbdata.PerformLayout();
            this.gbmahasiswa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_NPM;
        private System.Windows.Forms.Label label_hp;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.Label label_angkatan;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.GroupBox gb_tombol;
        private System.Windows.Forms.GroupBox gbdata;
        private System.Windows.Forms.GroupBox gbmahasiswa;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox npm;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.ComboBox angkatan;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label1;
    }
}

