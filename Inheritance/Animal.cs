using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    // Create a class Animal
    // give this class 4 members that all Animals have in common
    {
        public string AnimalType {get; set;}
        public int Age { get; set; }
        public string Sex { get; set; }
        public string SkinCovering { get; set; }     
        public bool IsAlive { get; set; }
        public bool CanFly { get; set; }
        public void Fly(bool canFly)
        {
            if (canFly == true)
            {
                Console.WriteLine("I'm Flying High");
            }
            else
            {
                Console.WriteLine("I can't Fly");
            }
        }

    }
}
