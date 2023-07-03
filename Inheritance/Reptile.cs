using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public int LengthOfReptile { get; set; }
        public bool HasSpots { get; set; }
        public bool HasTail { get; set; }
        public int LengthOfTongue { get; set; }

        public void ReptilianCreature()
        {
            Console.WriteLine($"Our reptile friend has: \n");
            Console.WriteLine($"Has a total length of {LengthOfReptile} inches.");
            Console.WriteLine($"It is {HasSpots} that he has spots.");
            Console.WriteLine($"Other animals close to this reptile indicate that it is {HasTail} that he has a tail.");
            Console.WriteLine($"When he senses danger he wiggles his {LengthOfTongue} inch long tongue at opposing predators.");
            Console.WriteLine($"He has {NumberOfLegs} legs and weighs {WeightOfAnimal} Lbs.");

        }
    }
}
