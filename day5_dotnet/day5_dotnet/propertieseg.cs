using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_dotnet
{
    class student
    {
        private string code = "N.A";
        private string Name = "Unknown";
        private int age = 0;
        private float marks = 60;

        //declare properties for all the private members
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public int _Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Marks
        {
            get { return marks; }
        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + " Age = " + _Age + " Marks = " + Marks;
        }
    }
    class propertieseg
    {
        public static void Main()
        {
            student stud = new student();

            stud.Code = "S001";
            stud._Age = 13;
            //stud.Marks = 56; 
            Console.WriteLine("Student Info: {0}",stud.ToString());
            Console.Read();
        }
    }
}
