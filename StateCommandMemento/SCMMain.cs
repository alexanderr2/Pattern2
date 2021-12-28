using Assignment2.StateCommandMemento.Machine;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public MachineMemento SavedMachine { get; set; }
        public void Run()
        {
            Console.WriteLine("Press Enter to turn machine ON or OFF");
            Console.WriteLine("Press 1 to type your text");
            Console.WriteLine("Press 2 to create a Memento");
            Console.WriteLine("Press 3 to Restore the Machine");
            Console.WriteLine("Press SpaceBar to exit the program");

            Machine1 machine = new Machine1();
            while (true)
            {
                var userinput = Console.ReadKey(true).Key;
                switch (userinput)
                {
                    case ConsoleKey.Enter:
                        machine.PowerSwitch();
                        break;

                    case ConsoleKey.Spacebar:
                        Environment.Exit(0);
                        break;

                    // Användaren får skriva in en text sträng, strängen sparas i ett kommando och sedan kör machine.Print(),
                    // OM MachineState = OFF så sparas strängen och printas ut när MachineState = ON
                    case ConsoleKey.D1:
                        Console.WriteLine("Please type the text you want to print!");
                        string inputText = Console.ReadLine();
                        // string inputText ska sparas i en lista? CommandPattern
                        machine.Print(inputText);
                        break;
                    case ConsoleKey.D2:
                        // Create a memento
                        SavedMachine = machine.CreateMemento();
                        break;
                    case ConsoleKey.D3:
                        // Do the restoration
                        SavedMachine.Restore();
                        break;
                    default:
                        Console.WriteLine("I dont know what you mean");
                        break;
                }
            }
        }
    }
}