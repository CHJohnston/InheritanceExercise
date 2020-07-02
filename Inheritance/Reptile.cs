using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class

    {
        public bool LiveBirth { get; set; }
        public bool DoesSwim { get; set; }
        public bool UseLegs { get; set; }
        public bool EatLiveFood { get; set; }

        public void ChangeColor(bool canChangeColors) 
        {
            if (canChangeColors == true)
            {
                Console.WriteLine("You have changed colors");
            }
            else 
            {
                Console.WriteLine("No Color Change");
            }
        }       
    }
}
