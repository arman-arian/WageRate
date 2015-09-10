using System;
using System.Globalization;
using System.Windows.Forms;

namespace WageRate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;

            var y0 = decimal.Parse(txtAmount.Text);
            var d = decimal.Parse(txtDuration.Text);
            var rate = decimal.Parse(txtRate.Text);
            var installment = decimal.Parse(txtInstal.Text);

            for (var i = 1; i <= d; i++)
            {
                var s = ((y0*rate*12)/1200)/12;
                y0 = y0 + s - installment;

                txtLog.Text += @"سود ماه " + i + @" : " + Math.Floor(s - installment) + @" مانده: " + Math.Floor(y0) + Environment.NewLine;
            }

            txtFinalAmount.Text = Math.Floor(y0).ToString(CultureInfo.InvariantCulture);
        }
    }
}
