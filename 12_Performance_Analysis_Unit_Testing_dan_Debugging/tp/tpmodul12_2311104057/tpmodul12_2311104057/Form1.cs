using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_2311104057
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputTextBox.Text, out int number))
            {
                resultLabel.Text = Utility.CariTandaBilangan(number);
            }
            else
            {
                try
                {
                    // Attempt to parse the input to check for overflow  
                    Convert.ToInt32(inputTextBox.Text);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Bilangan terlalu besar atau kecil untuk tipe data integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultLabel.Text = string.Empty;
                    return;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Input tidak valid. Silakan masukkan bilangan bulat.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultLabel.Text = string.Empty;
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static class Utility
        {
            public static string CariTandaBilangan(int a)
            {
                if (a < 0)
                    return "Negatif";
                else if (a > 0)
                    return "Positif";
                else
                    return "Nol";
            }
        }
    }
}
