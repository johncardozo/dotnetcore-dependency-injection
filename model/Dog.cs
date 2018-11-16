using System;

namespace iocExample.model
{
    class Dog : IAnimal
    {
        public void run()
        {
            Console.WriteLine("Dog running...");
        }
    }

}