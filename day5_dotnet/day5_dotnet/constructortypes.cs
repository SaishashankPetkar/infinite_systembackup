using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_dotnet
{
    class constructortypes
    {
        int var1;
        public constructortypes()
        {
            var1 = 6;
            Console.WriteLine("called thru 2nd constructor" + var1);
        }
        public constructortypes(int x):this()
        {
            
            Console.WriteLine("This is 2nd Constructor");
        }
        public constructortypes(int a,string s,double d) : this(25)
        {
            Console.WriteLine(a + " " + s + " " + d);
        }
        static void Main(string[] args)
        {
            constructortypes ct = new constructortypes(5,"hello",5.5);
            Console.Read();
        }
        
        public class dog
        {
            public string name;
            public int age;

            protected dog()
            {
                Console.WriteLine("We are construnting dog..");
            }
        }

        public class germansheperd : dog
        {
            public double fiestyfactor;

            public germansheperd(string name, int age,double ff)
            {
                Console.WriteLine("constructing german sheperd");
                string Name = name;
            }
        }
    }


    //class test : constructortypes
    //{
    //    public void checkingpvtconstructor()
    //    {
    //        constructortypes ct1 = new test();
    //    }
    //}
}
