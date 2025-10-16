using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Mostatil:Shape
    {
        public double tul { get; set; }
        public double arz { get; set; }
        public override void Input()
        {
            Console.WriteLine("enter tul");
            tul = double.Parse(Console.ReadLine());
            Console.WriteLine("enter arz");
            arz = double.Parse(Console.ReadLine());
        }
        public override double masahat()
        {
            return tul * arz;

        }
        public override double mohit()
        {
            return 2 * (tul + arz);
        }
    }
}
