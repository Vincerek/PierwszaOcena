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
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dataTeraz.Format = DateTimePickerFormat.Custom;
            dataTeraz.CustomFormat = "dd.mm.yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
