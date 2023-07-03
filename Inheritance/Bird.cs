using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public int LengthOfWings { get; set; }
        public bool HasBeek { get; set; }
        public bool CanFly { get; set; }
        public string ColorOfTailFeathers { get; set; }

        public void Birdie()
        {
            Console.WriteLine($"Our bird friend has: \n");
            Console.WriteLine($"{LengthOfWings} inch long wings.");
            Console.WriteLine($"It is {HasBeek} that he has a beek.");
            Console.WriteLine($"Other animals close to this bird indicate that it is {CanFly} that he can fly.");
            Console.WriteLine($"He is very colorful with {ColorOfTailFeathers} tail feathers.");
            Console.WriteLine($"He has {NumberOfLegs} legs and weighs {WeightOfAnimal} Lbs.");

        }
    }
}
