using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP1 {
    static class Output {
        /**
        *   This adds necessary data to the displayCheck request before it is displayed.
        */
        public static void displayCheck(int checkID, String payee, double dollarAmount, String memo) {
            OutputGUI output = new OutputGUI();

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

            // Display the check
            output.displayCheck(checkID, date, payee, dollarAmount, dollarText, memo);
        }
    }
}
