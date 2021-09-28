using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetMyCustomFormat();
            labelGodzina.Text = "Aktualna godzina to: " + DateTime.Now.ToString("HH:mm");
            LabelData.Text = "Aktualna data to: " + DateTime.Now.ToString("dd.MM.yyyy");
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dataUrodzenia.Format = DateTimePickerFormat.Custom;
            dataUrodzenia.CustomFormat = "dd.mm.yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelGodzina.Text = "Aktualna godzina to: " + DateTime.Now.ToString("HH:mm");
        }

        private void dataTeraz_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void bWypisz_Click(object sender, EventArgs e)
        {
            labelNazwisko.Font = new Font(labelNazwisko.Font, FontStyle.Bold);
            labelWiek.Font = new Font(labelWiek.Font, FontStyle.Bold);

            labelImie.Text = imie.Text;
            labelNazwisko.Text = nazwisko.Text;
            labelWiek.Text = "Lat: " + numericWiek.Value.ToString();
            labelDataUro.Text = dataUrodzenia.Value.ToString("dd.MM.yyyy");
            
            int Lata = Convert.ToInt32(Math.Round(numericWiek.Value, 0));
            if (Lata > 17)
            {
                labelDataUro.ForeColor = Color.Blue;
            }
            else
            {
                labelDataUro.ForeColor = Color.Green;
            }
            DateTime teraz = DateTime.Now;
            DateTime Pelnoletnosc = teraz.AddYears(-18);
            DateTime Urodzony = dataUrodzenia.Value;
            TimeSpan IleLat = terazPicker.Value - dataUrodzenia.Value;
            DateTime dt = new DateTime() + IleLat;
            if (dt.Year > Lata)
            {
                MessageBox.Show("Wiek z datą urodzenia się nie zgadza");
            }
            else if(dt.Year < Lata)
            {
                MessageBox.Show("Wiek z datą urodzenia się nie zgadza");
            }
        }

        private void imie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelImie.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            labelNazwisko.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            labelWiek.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            labelDataUro.Font = new Font("Times New Roman", 10, FontStyle.Regular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelImie.Font = new Font("Arial", 10, FontStyle.Regular);
            labelNazwisko.Font = new Font("Arial", 10, FontStyle.Bold);
            labelWiek.Font = new Font("Arial", 10, FontStyle.Bold);
            labelDataUro.Font = new Font("Arial", 10, FontStyle.Regular);
        }
    }
}
