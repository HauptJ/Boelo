using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP1;

namespace IP1 {
    static class Output {
        public static void displayCheck(int checkID, String payee, double dollarAmount, String memo) {
            OutputGUI output = new OutputGUI();
            InputProcessor ip = new InputProcessor();
            ip.Parse(dollarAmount);
            String dollarText = ip.PrintString();
            String date = DateTime.Now.ToString();
            output.displayCheck(checkID, date, payee, dollarAmount, dollarText, memo);
        }
    }
}
