using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactoryAssignment.Factory
{
    class AbstractFactory2
    {
        public IFactory somthing(string typeOfFactory)
        {
            if (typeOfFactory == "Dog")
            {
                return new DogFactory();
            }
            else
            {
                return new CatFactory();
            }
        }
    }
}
