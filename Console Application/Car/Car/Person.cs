//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo_B11
{
    class Person
    {
        private int weight;
        private int age;

        public int Age
        {
            get { return age; }

            set
            {
                if (value >= 25)
                {
                    age = 25;
                }
                else
                {
                    age = value;
                }

            }
        }
        public int Weight
        {
            get { return weight; }

            set
            {
                if (value >= 95)
                {
                    weight = 95;
                }
                else
                {
                    weight = value;
                }

            }
        }
        public void show()
        {
            Console.WriteLine();
            Console.WriteLine("Sushil Weight is "+weight);
            Console.WriteLine("Sushil Age is "+age);
       }
       public void show1()
        {
            Console.WriteLine();
            Console.WriteLine("Pranil Weight is " + weight);
            Console.WriteLine("Pranil Age is " + age);
        }
    }
}



