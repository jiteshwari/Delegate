using System;

namespace EventAndDelegates
{
    class EventAndDelegateUsingArray_of_Delegates
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition={0}", a + b);
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("Substraction ={0}", a - b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Multiply={0}", a * b);
        }
    }
    class ClsExample
    {
        delegate void DelOp(int x, int y);

        static void Main(string[] args)
        {
            // Delegate instantiation  
            DelOp[] obj =
           {
               new DelOp(EventAndDelegateUsingArray_of_Delegates.Add),
                new DelOp(EventAndDelegateUsingArray_of_Delegates.sub),
               new DelOp(EventAndDelegateUsingArray_of_Delegates.Mul)
           };
           for (int i = 0; i < obj.Length; i++)
           {
                obj[i](2,1);
                obj[i](3,1);
                obj[i](4,3);
           }
            Console.ReadLine();
        }
    }
}