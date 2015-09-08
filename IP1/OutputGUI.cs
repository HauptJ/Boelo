using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP1 {
    public partial class OutputGUI : Form {
        public OutputGUI() {
            InitializeComponent();
        }

        /**
        *   This displays the check in a window.
        */
        public void displayCheck(int checkID, String payee, double dollarAmount, String memo) {
            // Convert the decimal amount to a string
            InputProcessor ip = new InputProcessor();
            ip.Parse(dollarAmount);
            String dollarText = ip.PrintString();

            // Get the date for the check
            String day = DateTime.Now.Day.ToString();
            String month = DateTime.Now.Month.ToString();
            String date = (month.Length == 1 ? "0" + month : month) + "/"
                + (day.Length == 1 ? "0" + day : day) + "/"
                + DateTime.Now.Year;


            checkNumTopLabel.Text = checkID.ToString();
            checkNumBottomLabel.Text = checkID.ToString();
            dateLabel.Text = date;

            // Display the dollar amount correctly
            dollarsLabel.Text = String.Format("{0:n}", dollarAmount);

            // These loops make sure the underlined string reaches the desired length.
            int payeeLength = payeeLabel.Text.Length;
            payeeLabel.Text = payee;
            while (payeeLabel.Text.Length < payeeLength)
                payeeLabel.Text += " ";

            int dollarTextLength = dollarsTextLabel.Text.Length;
            dollarsTextLabel.Text = dollarText;
            while (dollarsTextLabel.Text.Length < dollarTextLength)
                dollarsTextLabel.Text += " ";

            // This adjusts the window size to fit the dollar text
            if (dollarsTextLabel.Text.Length > dollarTextLength)
                this.Width += (dollarsTextLabel.Text.Length - dollarTextLength) * 9;

            int memoLength = memoLabel.Text.Length;
            memoLabel.Text = memo;
            while (memoLabel.Text.Length < memoLength)
                memoLabel.Text += " ";
            
            // Show the window
            Application.Run(this);
        }

        private void OutputGUI_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label17_Click(object sender, EventArgs e) {

        }
    }
}
