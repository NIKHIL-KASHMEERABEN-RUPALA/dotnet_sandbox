using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_3
{
    internal class Cube
    {

        int volume;
        int length;
        public Cube(int length) {

            this.length = length; 

        }
        public void DisplayVolume()
        {
            this.volume = this.length * this.length * this.length;
            Console.WriteLine($"Volume of Cube is : {volume}");
        }
    }
}
