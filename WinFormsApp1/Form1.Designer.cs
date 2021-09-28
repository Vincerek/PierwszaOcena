
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
            this.dataTeraz = new System.Windows.Forms.DateTimePicker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LabelUrodzenie = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericWiek = new System.Windows.Forms.NumericUpDown();
            this.labelWiek = new System.Windows.Forms.Label();
            this.LabelTeraz = new System.Windows.Forms.Label();
            this.bWypisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // dataTeraz
            // 
            this.dataTeraz.Location = new System.Drawing.Point(579, 41);
            this.dataTeraz.Name = "dataTeraz";
            this.dataTeraz.Size = new System.Drawing.Size(200, 23);
            this.dataTeraz.TabIndex = 1;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 167);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
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
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(12, 77);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(64, 15);
            this.labelWiek.TabIndex = 7;
            this.labelWiek.Text = "Podaj wiek";
            // 
            // LabelTeraz
            // 
            this.LabelTeraz.AutoSize = true;
            this.LabelTeraz.Location = new System.Drawing.Point(579, 12);
            this.LabelTeraz.Name = "LabelTeraz";
            this.LabelTeraz.Size = new System.Drawing.Size(80, 15);
            this.LabelTeraz.TabIndex = 8;
            this.LabelTeraz.Text = "Aktualna data";
            // 
            // bWypisz
            // 
            this.bWypisz.Location = new System.Drawing.Point(356, 113);
            this.bWypisz.Name = "bWypisz";
            this.bWypisz.Size = new System.Drawing.Size(102, 52);
            this.bWypisz.TabIndex = 9;
            this.bWypisz.Text = "Wypisz dane";
            this.bWypisz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aktualna data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bWypisz);
            this.Controls.Add(this.LabelTeraz);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.numericWiek);
            this.Controls.Add(this.LabelUrodzenie);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.dataTeraz);
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
        private System.Windows.Forms.DateTimePicker dataTeraz;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LabelUrodzenie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericWiek;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.Label LabelTeraz;
        private System.Windows.Forms.Button bWypisz;
        private System.Windows.Forms.Label label1;
    }
}

