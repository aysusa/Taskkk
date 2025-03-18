using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    using System;

    class Bird : Animal
    {
        public bool CanSwim;
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
