namespace Kadra
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanowisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pensja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxPensja = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.comboBoxStanowisko = new System.Windows.Forms.ComboBox();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.textBoxFraza = new System.Windows.Forms.TextBox();
            this.comboBoxKolumny = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAwans = new System.Windows.Forms.Button();
            this.buttonPodwyzka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.imie,
            this.nazwisko,
            this.stanowisko,
            this.pensja});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // imie
            // 
            this.imie.HeaderText = "imie";
            this.imie.Name = "imie";
            // 
            // nazwisko
            // 
            this.nazwisko.HeaderText = "nazwisko";
            this.nazwisko.Name = "nazwisko";
            // 
            // stanowisko
            // 
            this.stanowisko.HeaderText = "stanowisko";
            this.stanowisko.Name = "stanowisko";
            // 
            // pensja
            // 
            this.pensja.HeaderText = "pensja";
            this.pensja.Name = "pensja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "stanowisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "pensja";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(678, 12);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 7;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(678, 43);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 8;
            // 
            // textBoxPensja
            // 
            this.textBoxPensja.Location = new System.Drawing.Point(678, 109);
            this.textBoxPensja.Name = "textBoxPensja";
            this.textBoxPensja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPensja.TabIndex = 10;
            this.textBoxPensja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPensja_KeyPress);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(691, 135);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 40);
            this.buttonDodaj.TabIndex = 11;
            this.buttonDodaj.Text = "Dodaj pracownika";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // comboBoxStanowisko
            // 
            this.comboBoxStanowisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStanowisko.FormattingEnabled = true;
            this.comboBoxStanowisko.Items.AddRange(new object[] {
            "kierownik",
            "lider",
            "pracownik produkcji"});
            this.comboBoxStanowisko.Location = new System.Drawing.Point(678, 78);
            this.comboBoxStanowisko.Name = "comboBoxStanowisko";
            this.comboBoxStanowisko.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStanowisko.TabIndex = 12;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(691, 218);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 39);
            this.buttonUsun.TabIndex = 13;
            this.buttonUsun.Text = "Usuń pracownika";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "id";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(678, 192);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 15;
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(337, 322);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(75, 23);
            this.buttonSzukaj.TabIndex = 16;
            this.buttonSzukaj.Text = "szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // textBoxFraza
            // 
            this.textBoxFraza.Location = new System.Drawing.Point(34, 324);
            this.textBoxFraza.Name = "textBoxFraza";
            this.textBoxFraza.Size = new System.Drawing.Size(170, 20);
            this.textBoxFraza.TabIndex = 17;
            // 
            // comboBoxKolumny
            // 
            this.comboBoxKolumny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKolumny.FormattingEnabled = true;
            this.comboBoxKolumny.Items.AddRange(new object[] {
            "id",
            "imie",
            "nazwisko",
            "stanowisko",
            "pensja"});
            this.comboBoxKolumny.Location = new System.Drawing.Point(210, 323);
            this.comboBoxKolumny.Name = "comboBoxKolumny";
            this.comboBoxKolumny.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKolumny.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Szukana fraza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kolumna:";
            // 
            // buttonAwans
            // 
            this.buttonAwans.Location = new System.Drawing.Point(681, 263);
            this.buttonAwans.Name = "buttonAwans";
            this.buttonAwans.Size = new System.Drawing.Size(97, 48);
            this.buttonAwans.TabIndex = 21;
            this.buttonAwans.Text = "Awansuj Pracownika o podanym ID";
            this.buttonAwans.UseVisualStyleBackColor = true;
            this.buttonAwans.Click += new System.EventHandler(this.buttonAwans_Click);
            // 
            // buttonPodwyzka
            // 
            this.buttonPodwyzka.Location = new System.Drawing.Point(681, 322);
            this.buttonPodwyzka.Name = "buttonPodwyzka";
            this.buttonPodwyzka.Size = new System.Drawing.Size(97, 49);
            this.buttonPodwyzka.TabIndex = 22;
            this.buttonPodwyzka.Text = "Daj podwyżkę pracownikowi o podanym ID";
            this.buttonPodwyzka.UseVisualStyleBackColor = true;
            this.buttonPodwyzka.Click += new System.EventHandler(this.buttonPodwyzka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPodwyzka);
            this.Controls.Add(this.buttonAwans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxKolumny);
            this.Controls.Add(this.textBoxFraza);
            this.Controls.Add(this.buttonSzukaj);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.comboBoxStanowisko);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxPensja);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxPensja;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanowisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn pensja;
        private System.Windows.Forms.ComboBox comboBoxStanowisko;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.TextBox textBoxFraza;
        private System.Windows.Forms.ComboBox comboBoxKolumny;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAwans;
        private System.Windows.Forms.Button buttonPodwyzka;
    }
}

