using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            
            Bird bird1 = new Bird();

            bird1.CanFly = true;
            bird1.HasFur = false;
            bird1.HasTeeth = true;
            bird1.HasBeek = true;
            bird1.LengthOfWings = 6;
            bird1.ColorOfTailFeathers = "Green";
            bird1.NumberOfLegs = 2;
            bird1.WeightOfAnimal = 3;

            bird1.Birdie();
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile reptile1 = new Reptile();

            reptile1.HasSpots = true;
            reptile1.HasFur = false;
            reptile1.HasTeeth = true;
            reptile1.HasTail = true;
            reptile1.LengthOfReptile = 38;
            reptile1.LengthOfTongue = 4;
            reptile1.NumberOfLegs = 4;
            reptile1.WeightOfAnimal = 16;

            reptile1.ReptilianCreature();
        }
    }
}
