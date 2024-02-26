// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    class Program : IDisposable
    {
        class Student
        {
            public static double Pi = 3.14;

            public System.Int32 RollNo;

            protected int contactNumber;

            public void Print()
            {
                int RollNo = 10;
                int newcontactNumber = 123456;
                newRollNo = 25;

                Console.WriteLine("Called from static class");
            }

        }

        ~Program()
        {

        }

        void IDisposable.Displose()
        {
            throw new NotImplementedException();
        }
    }


      
       /* public enum Gender
        {
            Male,
            Female
        }*/
        static void Main(string[] args)
        {

            var obj = new Student();
            obj.Print();
        obj.displose();
        }
    }
}
