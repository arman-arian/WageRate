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

            var amount = decimal.Parse(txtAmount.Text);
            var duration = decimal.Parse(txtDuration.Text);
            var rate = decimal.Parse(txtRate.Text);
            var installmentAmount = decimal.Parse(txtInstal.Text);

            for (var i = 1; i <= duration; i++)
            {
                var s = ((amount * rate * 12) / 1200) / 12;
                amount = amount + s - installmentAmount;

                txtLog.Text += @"سود ماه " + i + @" : " + Math.Floor(s - installmentAmount) + @" مانده: " + Math.Floor(amount) + Environment.NewLine;
            }

            txtFinalAmount.Text = Math.Floor(amount).ToString(CultureInfo.InvariantCulture);
        }
    }
}
