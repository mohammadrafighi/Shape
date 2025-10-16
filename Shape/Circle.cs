using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Circle:Shape
    {
        public double shoa { get; set; }
        public override void Input()
        {
            Console.WriteLine("enter shao");
            shoa = double.Parse(Console.ReadLine());
        }
        public override double masahat()
        {
            return shoa * shoa * 3.14;

        }
        public override double mohit()
        {
            return 2 * shoa * 3.14;
        }
    }
}
