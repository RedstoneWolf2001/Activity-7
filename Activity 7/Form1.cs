using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Approximate_Pi : Form
    {
        public Approximate_Pi()
        {
            InitializeComponent();
        }

        private void CalculateBTN_Click(object sender, EventArgs e)
        {
            int.TryParse(NumTermsTB.Text, out int digits);

            double result = 0.0;

            for (int i = 0; i < digits; i++)
            {
                result += 4.0 * (1.0 / (1.0 + (2.0 * i))) * Math.Pow(-1, i);
            }


            TermsLBL.Text = "Approximate value of pi after " + digits + " terms.";

            ResultLBL.Text = "= " + result.ToString();
        }
    }
}
