using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP1
{
    class tally
    {
        // values to be tracked by the tally component
        private int numChecks = 3002; //set check counter to initial value of 3002
        private decimal checkSum = 0; 

        //increments total number of checks when called
        //input: none
        //optput: none
        public void incrementNumChecks()
        {
            numChecks++;
        }

        //adds up sum of checks
        //input: user specified amount
        //output: none
        public void newSum(decimal amount)
        {
            checkSum = checkSum + amount;
        }

        //saftely returns the number of checks issued so far
        //input: none
        //output: numChecks (number of checks issued so far) as int

        public int getNumChecks()
        {
            return numChecks;
        }

        //saftely returns the current check sum
        //input: none
        //output: checkSum (current sum of checks issued) as decimal

        public decimal getCheckSum()
        {
            return checkSum;
        }

    }


}
