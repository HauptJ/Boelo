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
        public void displayCheck(int checkID, String date, String payee, double dollarAmount, String dollarText, String memo) {
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
