using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_dotnet
{
    public class account
    {
        public int id;
        public string name;
        public static float rateofint;

        public account(int Id, string Name)
        {
            id = Id;
            name = Name;
        }

        //static constructor initializes the static members
        static account()
        {
            rateofint = 7.5f;
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + rateofint);
        }
    }
    class staticconstructoreg
    {
        public static void Main()
        {
            account a1 = new account(1001, "sai");
            account a2 = new account(3345, "shahsank");
            a1.Display();
            a2.Display();
            Console.Read();
        }
    }
}
