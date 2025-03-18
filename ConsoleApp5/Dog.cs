using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    using System;

    class Dog : Animal
    {
        public bool HasTail;
        public void Bark()
        {
            Console.WriteLine("Dogs are barking");
        }
    }

}
