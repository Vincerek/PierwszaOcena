
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imie = new System.Windows.Forms.TextBox();
            this.dataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.LabelUrodzenie = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericWiek = new System.Windows.Forms.NumericUpDown();
            this.labelWiekNumeric = new System.Windows.Forms.Label();
            this.LabelData = new System.Windows.Forms.Label();
            this.bWypisz = new System.Windows.Forms.Button();
            this.labelGodzina = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelWiek = new System.Windows.Forms.Label();
            this.labelDataUro = new System.Windows.Forms.Label();
            this.terazPicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericWiek)).BeginInit();
            this.SuspendLayout();
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(12, 12);
            this.imie.Name = "imie";
            this.imie.PlaceholderText = "Podaj Imię";
            this.imie.Size = new System.Drawing.Size(100, 23);
            this.imie.TabIndex = 0;
            this.imie.TextChanged += new System.EventHandler(this.imie_TextChanged);
            // 
            // dataUrodzenia
            // 
            this.dataUrodzenia.Location = new System.Drawing.Point(12, 163);
            this.dataUrodzenia.Name = "dataUrodzenia";
            this.dataUrodzenia.Size = new System.Drawing.Size(200, 23);
            this.dataUrodzenia.TabIndex = 1;
            this.dataUrodzenia.Value = new System.DateTime(2021, 9, 28, 14, 16, 14, 0);
            this.dataUrodzenia.ValueChanged += new System.EventHandler(this.dataTeraz_ValueChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(12, 41);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.PlaceholderText = "Podaj Nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(100, 23);
            this.nazwisko.TabIndex = 2;
            // 
            // LabelUrodzenie
            // 
            this.LabelUrodzenie.AutoSize = true;
            this.LabelUrodzenie.Location = new System.Drawing.Point(12, 132);
            this.LabelUrodzenie.Name = "LabelUrodzenie";
            this.LabelUrodzenie.Size = new System.Drawing.Size(115, 15);
            this.LabelUrodzenie.TabIndex = 5;
            this.LabelUrodzenie.Text = "Podaj rok urodzenia:";
            // 
            // numericWiek
            // 
            this.numericWiek.Location = new System.Drawing.Point(12, 95);
            this.numericWiek.Name = "numericWiek";
            this.numericWiek.Size = new System.Drawing.Size(120, 23);
            this.numericWiek.TabIndex = 6;
            // 
            // labelWiekNumeric
            // 
            this.labelWiekNumeric.AutoSize = true;
            this.labelWiekNumeric.Location = new System.Drawing.Point(12, 77);
            this.labelWiekNumeric.Name = "labelWiekNumeric";
            this.labelWiekNumeric.Size = new System.Drawing.Size(64, 15);
            this.labelWiekNumeric.TabIndex = 7;
            this.labelWiekNumeric.Text = "Podaj wiek";
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Location = new System.Drawing.Point(579, 12);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(97, 15);
            this.LabelData.TabIndex = 8;
            this.LabelData.Text = "Aktualna data to:";
            // 
            // bWypisz
            // 
            this.bWypisz.Location = new System.Drawing.Point(332, 134);
            this.bWypisz.Name = "bWypisz";
            this.bWypisz.Size = new System.Drawing.Size(102, 52);
            this.bWypisz.TabIndex = 9;
            this.bWypisz.Text = "Wypisz dane";
            this.bWypisz.UseVisualStyleBackColor = true;
            this.bWypisz.Click += new System.EventHandler(this.bWypisz_Click);
            // 
            // labelGodzina
            // 
            this.labelGodzina.AutoSize = true;
            this.labelGodzina.Location = new System.Drawing.Point(579, 49);
            this.labelGodzina.Name = "labelGodzina";
            this.labelGodzina.Size = new System.Drawing.Size(116, 15);
            this.labelGodzina.TabIndex = 10;
            this.labelGodzina.Text = "Aktualna godzina to:";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(12, 229);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(30, 15);
            this.labelImie.TabIndex = 11;
            this.labelImie.Text = "Imie";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(12, 244);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(57, 15);
            this.labelNazwisko.TabIndex = 12;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(12, 259);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(33, 15);
            this.labelWiek.TabIndex = 13;
            this.labelWiek.Text = "Wiek";
            // 
            // labelDataUro
            // 
            this.labelDataUro.AutoSize = true;
            this.labelDataUro.Location = new System.Drawing.Point(12, 274);
            this.labelDataUro.Name = "labelDataUro";
            this.labelDataUro.Size = new System.Drawing.Size(84, 15);
            this.labelDataUro.TabIndex = 14;
            this.labelDataUro.Text = "DataUrodzenia";
            // 
            // terazPicker
            // 
            this.terazPicker.Location = new System.Drawing.Point(579, 362);
            this.terazPicker.Name = "terazPicker";
            this.terazPicker.Size = new System.Drawing.Size(200, 23);
            this.terazPicker.TabIndex = 15;
            this.terazPicker.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Zmień times";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Zmień arial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.terazPicker);
            this.Controls.Add(this.labelDataUro);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.labelGodzina);
            this.Controls.Add(this.bWypisz);
            this.Controls.Add(this.LabelData);
            this.Controls.Add(this.labelWiekNumeric);
            this.Controls.Add(this.numericWiek);
            this.Controls.Add(this.LabelUrodzenie);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.dataUrodzenia);
            this.Controls.Add(this.imie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericWiek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.DateTimePicker dataUrodzenia;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label LabelUrodzenie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericWiek;
        private System.Windows.Forms.Label labelWiekNumeric;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.Button bWypisz;
        private System.Windows.Forms.Label labelGodzina;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.Label labelDataUro;
        private System.Windows.Forms.DateTimePicker terazPicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

