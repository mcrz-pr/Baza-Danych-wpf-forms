namespace Baza_Danych
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
            this.textImie = new System.Windows.Forms.TextBox();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.Label();
            this.comboKlasa = new System.Windows.Forms.ComboBox();
            this.klasa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textImie
            // 
            this.textImie.Location = new System.Drawing.Point(482, 176);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(100, 20);
            this.textImie.TabIndex = 0;
            // 
            // textNazwisko
            // 
            this.textNazwisko.Location = new System.Drawing.Point(482, 220);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textNazwisko.TabIndex = 1;
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Location = new System.Drawing.Point(387, 179);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(26, 13);
            this.imie.TabIndex = 2;
            this.imie.Text = "Imię";
            this.imie.Click += new System.EventHandler(this.imie_Click);
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSize = true;
            this.nazwisko.Location = new System.Drawing.Point(387, 227);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(53, 13);
            this.nazwisko.TabIndex = 3;
            this.nazwisko.Text = "Nazwisko";
            // 
            // comboKlasa
            // 
            this.comboKlasa.FormattingEnabled = true;
            this.comboKlasa.Items.AddRange(new object[] {
            "1a",
            "1b",
            "1c",
            "1d",
            "2a",
            "2b",
            "2c",
            "2d",
            "3a",
            "3b",
            "3c",
            "3d",
            "4a",
            "4b",
            "4c",
            "4d"});
            this.comboKlasa.Location = new System.Drawing.Point(482, 266);
            this.comboKlasa.Name = "comboKlasa";
            this.comboKlasa.Size = new System.Drawing.Size(100, 21);
            this.comboKlasa.TabIndex = 4;
            // 
            // klasa
            // 
            this.klasa.AutoSize = true;
            this.klasa.Location = new System.Drawing.Point(387, 274);
            this.klasa.Name = "klasa";
            this.klasa.Size = new System.Drawing.Size(33, 13);
            this.klasa.TabIndex = 5;
            this.klasa.Text = "Klasa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(390, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zaaplikuj";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 568);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textImie);
            this.tabPage1.Controls.Add(this.klasa);
            this.tabPage1.Controls.Add(this.textNazwisko);
            this.tabPage1.Controls.Add(this.comboKlasa);
            this.tabPage1.Controls.Add(this.imie);
            this.tabPage1.Controls.Add(this.nazwisko);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dodaj ucznia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wyszukaj ucznia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DODAJ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.Label nazwisko;
        private System.Windows.Forms.ComboBox comboKlasa;
        private System.Windows.Forms.Label klasa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
    }
}

