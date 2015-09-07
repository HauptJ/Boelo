using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace IP1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creating new tally.
            tally CheckTally = new tally();

            // Create a while flag for entering more than one check.
            bool Rep;
            do
            {
                // Creating and running input form.
                CheckInputForm InForm = new CheckInputForm();
                Application.Run(InForm);
                // Code doesn't advance until the user successfully enters a check. 
                // So beyond this point, assume a check has been entered successfully. 

                // Debug for input form
                MessageBox.Show("Name: " + InForm.getName() + "\nAmount: " + InForm.getAmount() + "\nMemo: " + InForm.getMemo() );

                // increments number of checks
                CheckTally.incrementNumChecks();

                // sum up new check sum
                CheckTally.newSum(InForm.getAmount());

                // These get the vaules from the input form. 
                // Name is trimmed of whitespace and amount is positive non-zero
                // InForm.getName()
                // InForm.getAmount()
                // InForm.getMemo()

                // Creates the input processor
                InputProcessor proc = new InputProcessor();

                // This method converts the getAmount into the string so the decimal and the whole number can be evaluated
                proc.Parse(InForm.getAmount());

                // This method prints the dollar amount in the word format
                string dollarAmountAsTxt = proc.PrintString();

                // debug for amount to string
                // MessageBox.Show("Amount: "+InForm.getAmount()+"\nAmount Text: "+dollarAmountAsTxt);
        


                // Creates a message box asking if they want to enter another check.
                DialogResult dialogResult = MessageBox.Show("Would you like to enter another check?", "Check - More", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    Rep = true;
                }
                else
                {
                    Rep = false;
                }
            }
            while(Rep);
            
            // debug for tally 
            //MessageBox.Show("sum: " + CheckTally.getCheckSum() + "\nNum Checks: " + CheckTally.getNumChecks());
        }
    }
}
