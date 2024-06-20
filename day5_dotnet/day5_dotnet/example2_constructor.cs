using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_dotnet
{
    class parent
    {
        int ID;
        public parent(int x)
        {
            ID = x;
            Console.WriteLine(ID);
        }
    }
    class child : parent
    {
        string Name;
        public child(int a,string s) : base(a)
        {
            Name = s;
        }
    }
    class example2_constructor
    {
        public static void Main()
        {
            //parent p = new parent();
            child c = new child(5,"sai");
            Console.Read();

        }
    }
}
