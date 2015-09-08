using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// A Double over fifteen characters not counting the decimal will start to round or get ride of the value affter the decimal.

namespace IP1
{
    class IP01_InputProcessor_Boelo
    {
        private long wholeNumber; 
        private string decNum;


        // Parses the string and converts the whole number side into an int then stors the value. 
        // Parse also stories the deciaml side of the double.
        // Wont Convert Any Number over 
        public void Parse(double value)
        {
            string text = value.ToString();
            string[] num = text.Split('.');
            int size = num.Length;

            // Checks to see if there is a Decimal Number
            if (size == 1)
            {
                decNum = "00";
            }
            if (size != 1)
            {
                DecNum(num[1]);
            }

            wholeNumber = Convert.ToInt64(num[0]);

        }

        // Checks to see if there need to be a zero added to the decNum string
        private void DecNum(string something)
        {

            switch (something)
            {
                case "1":
                    decNum = "10";
                    break;
                case "2":
                    decNum = "20";
                    break;
                case "3":
                    decNum = "30";
                    break;
                case "4":
                    decNum = "40";
                    break;
                case "5":
                    decNum = "50";
                    break;
                case "6":
                    decNum = "60";
                    break;
                case "7":
                    decNum = "70";
                    break;
                case "8":
                    decNum = "80";
                    break;
                case "9":
                    decNum = "90";
                    break;
                default:
                    decNum = something;
                    break;
            }
        }

        // Converts the Double to a string so it can be parsed
        private string Double_to_String(double val)
        {
            string text = val.ToString();
            return text;
        }

        //Selects which word to use in the Tens spoit for any gouping of three
        private string Ten(long value)
        {
            string tensWord = "";
            switch (value)
            {
                case 2:
                    tensWord = "Twenty ";
                    break;
                case 3:
                    tensWord = "Thirty ";
                    break;
                case 4:
                    tensWord = "Fourty ";
                    break;
                case 5:
                    tensWord = "Fifty ";
                    break;
                case 6:
                    tensWord = "Sixty ";
                    break;
                case 7:
                    tensWord = "Seventy ";
                    break;
                case 8:
                    tensWord = "Eighty ";
                    break;
                case 9:
                    tensWord = "Ninety ";
                    break;

            }
            return tensWord;
        }

        //Selects which word to use in the Tens and ones spot if it is in the teens range
        //spoit for any gouping of three
        private string Teens(long value)
        {
            string teensWord = "";
            switch (value)
            {
                case 11:
                    teensWord = "Eleven ";
                    break;
                case 12:
                    teensWord = "Twelve ";
                    break;
                case 13:
                    teensWord = "Thirteen ";
                    break;
                case 14:
                    teensWord = "Fourteen ";
                    break;
                case 15:
                    teensWord = "Fifteen ";
                    break;
                case 16:
                    teensWord = "Sixteen ";
                    break;
                case 17:
                    teensWord = "Seventeen ";
                    break;
                case 18:
                    teensWord = "Eighteen ";
                    break;
                case 19:
                    teensWord = "Nineteen ";
                    break;
            }
            return teensWord;
        }

        //Selects which word to use in the ones spoit for any gouping of three
        private string Ones(long value)
        {
            string onesWord = "";
            switch (value)
            {
                case 1:
                    onesWord = "One ";
                    break;
                case 2:
                    onesWord = "Two ";
                    break;
                case 3:
                    onesWord = "Three ";
                    break;
                case 4:
                    onesWord = "Four ";
                    break;
                case 5:
                    onesWord = "Five ";
                    break;
                case 6:
                    onesWord = "Six ";
                    break;
                case 7:
                    onesWord = "Seven ";
                    break;
                case 8:
                    onesWord = "Eight ";
                    break;
                case 9:
                    onesWord = "Nine ";
                    break;
                case 10:
                    onesWord = "Ten ";
                    break;
            }
            return onesWord;
        }

        // Convertes the Whole Number side of the Double to Word Form through recursion
        private string Num_Word(long some)
        {
            long temp = 0;
            string numAsWord = "";
            if (some != 0)
            {
                if (some >= 1000000000000)
                {
                    temp = some / 1000000000000;
                    numAsWord += Num_Word(temp);
                    numAsWord += "Trillion ";
                    some = some % 1000000000000;
                    Num_Word(some);
                }

                if (some >= 1000000000)
                {
                    temp = some / 1000000000;
                    numAsWord += Num_Word(temp);
                    numAsWord += "Billion ";
                    some = some % 1000000000;
                    Num_Word(some);
                }

                if (some >= 1000000)
                {
                    temp = some / 1000000;
                    numAsWord += Num_Word(temp);
                    numAsWord += "Million ";
                    some = some % 1000000;
                    Num_Word(some);
                }

                if (some >= 1000)
                {
                    temp = some / 1000;
                    numAsWord += Num_Word(temp);
                    numAsWord += "Thousand ";
                    some = some % 1000;
                    Num_Word(some);
                }

                if (some >= 100)
                {
                    temp = some / 100;
                    numAsWord += Num_Word(temp);
                    numAsWord += "Hundred ";
                    some = some % 100;
                    Num_Word(some);
                }

                if (some >= 20)
                {
                    temp = some / 10;
                    numAsWord += Ten(temp);
                    some = some % 10;
                    Num_Word(some);
                }

                if (some >= 11)
                {
                    numAsWord += Teens(some);
                    some = 0;
                    Num_Word(some);
                }

                if (some >= 0)
                {
                    numAsWord += Ones(some);
                }
            }
            else
            {
                numAsWord = "Zero";
            }
            return numAsWord;
        }

        // Print the Dollar Amount in Word Form
        public string PrintString()
        {
            string dollarName = Num_Word(wholeNumber);
            dollarName += "and " + decNum + "/100";
            return dollarName;
        }
    }
}
