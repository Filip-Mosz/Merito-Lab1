using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Witaj, swiecie";
            label1.ForeColor = System.Drawing.Color.Red;
            //todo po przetłumaczeniu zmienić kolor
            // jeszcze jeden guzik którego naciśnięcie spowoduje przetłumaczenie na angielski
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }
    }
}
