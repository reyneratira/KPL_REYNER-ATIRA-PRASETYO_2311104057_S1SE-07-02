using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul12_2311104057
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                int hasil = Utilities.CariNilaiPangkat(a, b);
                labelOutput.Text = $"{hasil}";
            }
            catch (Exception ex)
            {
                labelOutput.Text = "Input tidak valid";
            }

        }
    }
}
