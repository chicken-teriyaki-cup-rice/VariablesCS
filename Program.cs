using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Epic();
        }
        static void Epic()
        {
            int numberOfCupOfCoffee = 2; 
            string fullName = "Walrus Autotune";
            DateTime today = DateTime.Now;
            Console.WriteLine("Aloha, my name is {1}. I drink roughly {0} cups of coffee a day. Today is {2}, it's {2:h:mm tt} now.", numberOfCupOfCoffee, fullName, today);
        }
    }
}
