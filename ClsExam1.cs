using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    class Student
    {
        int Sid;
        string name;
        string location;
        public int  SId
        {
            set { Sid = value; }
            get { return Sid; }
        }
        public string Sname
        {
            set { name = value; }
            get { return name; }
        }
        public string Slocation
        {
            set { location = value; }
            get { return location; }
        }

        public string SName { get; internal set; }
        public int SRollNo { get; internal set; }
    }
    class ClsProperty : Student
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student();
            Console.WriteLine("enter student Details:");
            obj1.SId = Convert.ToInt32(Console.ReadLine());
            obj1.SRollNo = Convert.ToInt32(Console.ReadLine());

            obj1.SName = Console.ReadLine();
            obj1.Slocation = Console.ReadLine();
            Console.WriteLine("Id is :" + obj1.SId);        
            Console.WriteLine("Name is :" + obj1.SName);
            Console.WriteLine("location is :" + obj1.SName);
            Console.Read();
        }
    }

}
