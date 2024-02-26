using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_B11
{
   class Car
    {
        //Data
        public int Height;
        public int Length;
        public int Width;

        public string color;
        //Behaviour
        public void Start()
        {
            Console.WriteLine("Car =>  Height- {0} , Color- {1}", Height, color);
            Console.WriteLine("Car Start..!!");
        }
        public void Stop()
        {
            Console.WriteLine("Car =>  Height- {0} , Color- {1}", Height, color);
            Console.WriteLine("Car Stop...!!");
        }

         
    }
}
