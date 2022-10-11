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
            this.SuspendLayout();
            // 
            // textImie
            // 
            this.textImie.Location = new System.Drawing.Point(109, 24);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(100, 20);
            this.textImie.TabIndex = 0;
            // 
            // textNazwisko
            // 
            this.textNazwisko.Location = new System.Drawing.Point(109, 50);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textNazwisko.TabIndex = 1;
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Location = new System.Drawing.Point(39, 27);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(26, 13);
            this.imie.TabIndex = 2;
            this.imie.Text = "Imię";
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSize = true;
            this.nazwisko.Location = new System.Drawing.Point(28, 53);
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
            this.comboKlasa.Location = new System.Drawing.Point(109, 76);
            this.comboKlasa.Name = "comboKlasa";
            this.comboKlasa.Size = new System.Drawing.Size(100, 21);
            this.comboKlasa.TabIndex = 4;
            // 
            // klasa
            // 
            this.klasa.AutoSize = true;
            this.klasa.Location = new System.Drawing.Point(39, 79);
            this.klasa.Name = "klasa";
            this.klasa.Size = new System.Drawing.Size(33, 13);
            this.klasa.TabIndex = 5;
            this.klasa.Text = "Klasa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(61, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zaaplikuj";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.klasa);
            this.Controls.Add(this.comboKlasa);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.textImie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.Label nazwisko;
        private System.Windows.Forms.ComboBox comboKlasa;
        private System.Windows.Forms.Label klasa;
        private System.Windows.Forms.Button button1;
    }
}

