using Assignment2.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactoryAssignment.Factory
{
    class DogFactory : IFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Dog(name);
        }

    }
}
