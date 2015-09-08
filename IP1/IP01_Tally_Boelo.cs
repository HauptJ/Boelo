using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP1
{
    class IP01_Tally_Boelo
    {
        // values to be tracked by the tally component
        private int numChecks = 3002; //set check counter to initial value of 3002

        private int checksWrote = 0;

        private double checkSum = 0;
       
        public object InForm { get; internal set; }

        //increments total number of checks and check number when called
        //input: none
        //optput: none
        public void incrementNumChecks()
        {
            numChecks++;

            checksWrote++;
        }

        //adds up sum of checks
        //input: user specified amount
        //output: none
        public void newSum(double amount)
        {
            checkSum = checkSum + amount;
        }

        //saftely returns the number of checks issued so far
        //input: none
        //output: numChecks (checkNumber) as int

        public int getNumChecks()
        {
            return numChecks;
        }

        //saftely returns the number of checks issued so far
        //input: none
        //output: number of checks wrote as int

        public int getNumChecksWrote()
        {
            return checksWrote;
        }

        //saftely returns the current check sum
        //input: none
        //output: checkSum (current sum of checks issued) as decimal

        public double getCheckSum()
        {
            return checkSum;
        }

    }


}
