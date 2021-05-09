using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiscalYearCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            resetResult();
            calculate();
        }

        private void calculate()
        {
            FiscalCalculation calc = new FiscalCalculation();
            var fiscal = calc.GetFiscal(tDate.Text);
            if (fiscal == null)
            {
                MessageBox.Show($"{tDate.Text} is invalid");
                tDate.Text = "";
                return;
            } 

            lfyear.Text = fiscal.Year.ToString();
            lfdoy.Text = fiscal.Day.ToString();
            lfwoy.Text = fiscal.Woy.ToString();
            lfpoy.Text = fiscal.Poy.ToString();
            lfwini.Text = fiscal.Wini.ToShortDateString();

        }
        private void resetResult()
        {
            lfyear.Text = "";
            lfdoy.Text = "";
            lfwoy.Text = "";
            lfpoy.Text = "";
            lfwini.Text = "";
        }
    }
}
