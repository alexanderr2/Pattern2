using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterClass
    {
        public void PrintingStringsAsInts()
        {
            ReturningStrings returnString = new ReturningStrings();
            PrintingInts printingInts = new PrintingInts();

            var inputString = returnString.ReturnString();
            var StringToInt = Int32.Parse(inputString);

            printingInts.Print(StringToInt);
        }
    }
}
