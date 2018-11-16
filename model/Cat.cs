using System;

namespace iocExample.model
{
    class Cat : IAnimal
    {        
        public void run()
        {
            Console.WriteLine("Cat running...");
        }
    }

}