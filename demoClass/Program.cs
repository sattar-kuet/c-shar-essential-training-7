using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Shanto";
            person.walk();

            person.name = "Robin";
            person.walk();
        }
    }
}
