using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    class FacadeMain
    {
        public void Run()
        {
            // Write a facade to make it easier to save and load words

            FacadeClass facadeClass = new FacadeClass();
            facadeClass.SaveWord();
            facadeClass.LoadWord();
            
        }
    }
}
