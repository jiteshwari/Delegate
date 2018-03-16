using System;
namespace EventAndDelegate
{

    class ClsProgram
    {
        public delegate void delmethod();
        public class Property
        {
            public static void display()
            {
                Console.WriteLine("Hello!");
            }
            public static void show()
            {
                Console.WriteLine("Hema!");
            }
            public void print()
            {
                Console.WriteLine("Priya");
            }
        }
        static void Main(string[] args)
        {
            // here we have assigned static method show() of class program to delegate delmethod()
            delmethod del1 = Property.show;
            // here we have assigned static method display() of class program to delegate delmethod() using new operator
             delmethod del2 = new delmethod(Property.display);
             Property obj = new Property();
            // here first we have create instance of class program and assigned the method print() to the delegate i.e. delegate with class
            delmethod del3 = obj.print;
            del1();//call method
            del2();
            del3();
            Console.ReadLine();
        }
    }
}