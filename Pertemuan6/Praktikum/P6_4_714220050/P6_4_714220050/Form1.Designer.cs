namespace P6_4_714220050
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNomorHP = new System.Windows.Forms.Label();
            this.labelTanggalCheckIn = new System.Windows.Forms.Label();
            this.labelTanggalCheckOut = new System.Windows.Forms.Label();
            this.labelJenisKamar = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNomorHP = new System.Windows.Forms.TextBox();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.textBoxJenisKamar = new System.Windows.Forms.TextBox();
            this.buttonReservasi = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Reservasi Hotel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(80, 54);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            this.labelNama.Click += new System.EventHandler(this.labelNama_Click);
            // 
            // labelNomorHP
            // 
            this.labelNomorHP.AutoSize = true;
            this.labelNomorHP.Location = new System.Drawing.Point(80, 83);
            this.labelNomorHP.Name = "labelNomorHP";
            this.labelNomorHP.Size = new System.Drawing.Size(56, 13);
            this.labelNomorHP.TabIndex = 2;
            this.labelNomorHP.Text = "Nomor HP";
            // 
            // labelTanggalCheckIn
            // 
            this.labelTanggalCheckIn.AutoSize = true;
            this.labelTanggalCheckIn.Location = new System.Drawing.Point(80, 108);
            this.labelTanggalCheckIn.Name = "labelTanggalCheckIn";
            this.labelTanggalCheckIn.Size = new System.Drawing.Size(91, 13);
            this.labelTanggalCheckIn.TabIndex = 3;
            this.labelTanggalCheckIn.Text = "Tanggal Check in";
            // 
            // labelTanggalCheckOut
            // 
            this.labelTanggalCheckOut.AutoSize = true;
            this.labelTanggalCheckOut.Location = new System.Drawing.Point(80, 136);
            this.labelTanggalCheckOut.Name = "labelTanggalCheckOut";
            this.labelTanggalCheckOut.Size = new System.Drawing.Size(100, 13);
            this.labelTanggalCheckOut.TabIndex = 4;
            this.labelTanggalCheckOut.Text = "Tanggal Check Out";
            // 
            // labelJenisKamar
            // 
            this.labelJenisKamar.AutoSize = true;
            this.labelJenisKamar.Location = new System.Drawing.Point(80, 166);
            this.labelJenisKamar.Name = "labelJenisKamar";
            this.labelJenisKamar.Size = new System.Drawing.Size(37, 13);
            this.labelJenisKamar.TabIndex = 5;
            this.labelJenisKamar.Text = "Kamar";
            this.labelJenisKamar.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(276, 47);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 6;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            this.textBoxNama.Leave += new System.EventHandler(this.textBoxNama_Leave);
            // 
            // textBoxNomorHP
            // 
            this.textBoxNomorHP.Location = new System.Drawing.Point(276, 80);
            this.textBoxNomorHP.Name = "textBoxNomorHP";
            this.textBoxNomorHP.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomorHP.TabIndex = 7;
            this.textBoxNomorHP.Leave += new System.EventHandler(this.textBoxNomorHP_Leave);
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(276, 106);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckIn.TabIndex = 8;
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(276, 136);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckOut.TabIndex = 9;
            // 
            // textBoxJenisKamar
            // 
            this.textBoxJenisKamar.Location = new System.Drawing.Point(276, 163);
            this.textBoxJenisKamar.Name = "textBoxJenisKamar";
            this.textBoxJenisKamar.Size = new System.Drawing.Size(100, 20);
            this.textBoxJenisKamar.TabIndex = 10;
            this.textBoxJenisKamar.Click += new System.EventHandler(this.textBoxJenisKamar_Click);
            this.textBoxJenisKamar.Leave += new System.EventHandler(this.textBoxJenisKamar_Leave);
            // 
            // buttonReservasi
            // 
            this.buttonReservasi.Location = new System.Drawing.Point(394, 190);
            this.buttonReservasi.Name = "buttonReservasi";
            this.buttonReservasi.Size = new System.Drawing.Size(75, 23);
            this.buttonReservasi.TabIndex = 11;
            this.buttonReservasi.Text = "Reservasi";
            this.buttonReservasi.UseVisualStyleBackColor = true;
            this.buttonReservasi.Click += new System.EventHandler(this.buttonReservasi_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 225);
            this.Controls.Add(this.buttonReservasi);
            this.Controls.Add(this.textBoxJenisKamar);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.Controls.Add(this.textBoxNomorHP);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelJenisKamar);
            this.Controls.Add(this.labelTanggalCheckOut);
            this.Controls.Add(this.labelTanggalCheckIn);
            this.Controls.Add(this.labelNomorHP);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "j";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNomorHP;
        private System.Windows.Forms.Label labelTanggalCheckIn;
        private System.Windows.Forms.Label labelTanggalCheckOut;
        private System.Windows.Forms.Label labelJenisKamar;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNomorHP;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.TextBox textBoxJenisKamar;
        private System.Windows.Forms.Button buttonReservasi;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

