using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
   public class Moraba:Shape
    {
        public double zel { get; set; }
        public override void Input()
        {
            Console.WriteLine("enter zel:");
            zel = double.Parse(Console.ReadLine());
        }
        public override double masahat()
        {
            return zel * zel;

        }
        public override double mohit()
        {
            return zel * 4;
        }
    }
}
