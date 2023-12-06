namespace P7_1_714220050
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
            this.label_Nama = new System.Windows.Forms.Label();
            this.label_Prodi = new System.Windows.Forms.Label();
            this.label_Kelas = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonTPesan = new System.Windows.Forms.Button();
            this.list_kegiatan = new System.Windows.Forms.Label();
            this.rbSenin = new System.Windows.Forms.RadioButton();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbTravelling = new System.Windows.Forms.CheckBox();
            this.cbTidur = new System.Windows.Forms.CheckBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonRForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Nama
            // 
            this.label_Nama.AutoSize = true;
            this.label_Nama.Location = new System.Drawing.Point(32, 37);
            this.label_Nama.Name = "label_Nama";
            this.label_Nama.Size = new System.Drawing.Size(35, 13);
            this.label_Nama.TabIndex = 0;
            this.label_Nama.Text = "Nama";
            // 
            // label_Prodi
            // 
            this.label_Prodi.AutoSize = true;
            this.label_Prodi.Location = new System.Drawing.Point(32, 77);
            this.label_Prodi.Name = "label_Prodi";
            this.label_Prodi.Size = new System.Drawing.Size(31, 13);
            this.label_Prodi.TabIndex = 1;
            this.label_Prodi.Text = "Prodi";
            // 
            // label_Kelas
            // 
            this.label_Kelas.AutoSize = true;
            this.label_Kelas.Location = new System.Drawing.Point(32, 110);
            this.label_Kelas.Name = "label_Kelas";
            this.label_Kelas.Size = new System.Drawing.Size(33, 13);
            this.label_Kelas.TabIndex = 2;
            this.label_Kelas.Text = "Kelas";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(133, 30);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(206, 20);
            this.textBoxNama.TabIndex = 3;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(133, 74);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(206, 20);
            this.textBoxProdi.TabIndex = 4;
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(133, 110);
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(206, 20);
            this.textBoxKelas.TabIndex = 5;
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(133, 151);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(75, 34);
            this.buttonCek.TabIndex = 6;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTPesan
            // 
            this.buttonTPesan.Location = new System.Drawing.Point(241, 151);
            this.buttonTPesan.Name = "buttonTPesan";
            this.buttonTPesan.Size = new System.Drawing.Size(98, 34);
            this.buttonTPesan.TabIndex = 7;
            this.buttonTPesan.Text = "Tutup Pesan";
            this.buttonTPesan.UseVisualStyleBackColor = true;
            this.buttonTPesan.Click += new System.EventHandler(this.buttonTPesan_Click);
            // 
            // list_kegiatan
            // 
            this.list_kegiatan.AutoSize = true;
            this.list_kegiatan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_kegiatan.Location = new System.Drawing.Point(188, 206);
            this.list_kegiatan.Name = "list_kegiatan";
            this.list_kegiatan.Size = new System.Drawing.Size(97, 18);
            this.list_kegiatan.TabIndex = 8;
            this.list_kegiatan.Text = "LIST KEGIATAN";
            // 
            // rbSenin
            // 
            this.rbSenin.AutoSize = true;
            this.rbSenin.Location = new System.Drawing.Point(35, 237);
            this.rbSenin.Name = "rbSenin";
            this.rbSenin.Size = new System.Drawing.Size(52, 17);
            this.rbSenin.TabIndex = 9;
            this.rbSenin.TabStop = true;
            this.rbSenin.Text = "Senin";
            this.rbSenin.UseVisualStyleBackColor = true;
            this.rbSenin.CheckedChanged += new System.EventHandler(this.rbSenin_CheckedChanged);
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(35, 264);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(60, 17);
            this.rbMinggu.TabIndex = 10;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu";
            this.rbMinggu.UseVisualStyleBackColor = true;
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Location = new System.Drawing.Point(35, 304);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(55, 17);
            this.cbKuliah.TabIndex = 11;
            this.cbKuliah.Text = "Kuliah";
            this.cbKuliah.UseVisualStyleBackColor = true;
            // 
            // cbTravelling
            // 
            this.cbTravelling.AutoSize = true;
            this.cbTravelling.Location = new System.Drawing.Point(35, 327);
            this.cbTravelling.Name = "cbTravelling";
            this.cbTravelling.Size = new System.Drawing.Size(72, 17);
            this.cbTravelling.TabIndex = 12;
            this.cbTravelling.Text = "Travelling";
            this.cbTravelling.UseVisualStyleBackColor = true;
            // 
            // cbTidur
            // 
            this.cbTidur.AutoSize = true;
            this.cbTidur.Location = new System.Drawing.Point(35, 350);
            this.cbTidur.Name = "cbTidur";
            this.cbTidur.Size = new System.Drawing.Size(50, 17);
            this.cbTidur.TabIndex = 13;
            this.cbTidur.Text = "Tidur";
            this.cbTidur.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(133, 375);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(91, 28);
            this.buttonPrint.TabIndex = 14;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonRForm
            // 
            this.buttonRForm.Location = new System.Drawing.Point(264, 373);
            this.buttonRForm.Name = "buttonRForm";
            this.buttonRForm.Size = new System.Drawing.Size(93, 30);
            this.buttonRForm.TabIndex = 15;
            this.buttonRForm.Text = "Reset Form";
            this.buttonRForm.UseVisualStyleBackColor = true;
            this.buttonRForm.Click += new System.EventHandler(this.buttonRForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 407);
            this.Controls.Add(this.buttonRForm);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.cbTidur);
            this.Controls.Add(this.cbTravelling);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.rbMinggu);
            this.Controls.Add(this.rbSenin);
            this.Controls.Add(this.list_kegiatan);
            this.Controls.Add(this.buttonTPesan);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label_Kelas);
            this.Controls.Add(this.label_Prodi);
            this.Controls.Add(this.label_Nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nama;
        private System.Windows.Forms.Label label_Prodi;
        private System.Windows.Forms.Label label_Kelas;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonTPesan;
        private System.Windows.Forms.Label list_kegiatan;
        private System.Windows.Forms.RadioButton rbSenin;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbTravelling;
        private System.Windows.Forms.CheckBox cbTidur;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonRForm;
    }
}

