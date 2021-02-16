using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace TestProject2
{
    class Program
    {
        public static readonly double Pi = 3.14;
        public static List<int> arr;
        public static int[] arr2;
        //public static Shape obj;
        static void Main(string[] args)
        {
           string name = "";
           if("".Equals(name))
            {
                Console.WriteLine("if loop entered!");
            }
            if (name.Equals(string.Empty))
            {

            }
            if (name.Equals(""))
            {

            }
        }
        Program c = new Program();
        public int[] GetResults1(int[] arr)
        {
            return null;
        }

        public IEnumerable<string> GetResults2()
        {
            return null;
        }

        public IEnumerable<string> GetResults3() => null; 
        public IEnumerable<int> Results4
        {
            get
             {
                return null;
            }
        }

        public List<int> Results5 => null;

        public void DoSomething(int p1,int p2,int p3,int p4,int p5)
        {
            //do something
        }
        public void display()
        {
            string color = "blue";
            string name = "ishmael";

            List<string> strings = new List<string>();
            strings.Add(color);
            strings.Add(name);
            string[] stringArray = strings.ToArray();

            if(strings.IndexOf(color) > 0)
            {
                // ...
            }
            if (name.IndexOf("ish") > 0)
            {
                // ...
            }
            if (name.IndexOf("ae") > 0)
            {
                // ..
            }
            if (Array.IndexOf(stringArray, color) > 0)
            {
                // ...
            }
          
              for (int i = 0; i < 6; i--)  
              {
                    //do something
                                            
              }
      
        }

        internal string CheckHttp(string var)
        {
            throw new NotImplementedException();
        }

        internal string cwe327(string var1)
        {
            throw new NotImplementedException();
        }
    }
}
