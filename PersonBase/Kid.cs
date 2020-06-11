using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBase
{
    public class Kid:Person
    {
        public Kid(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Introduce()
        {
            Console.WriteLine("My name is {0},I'm {1}",name,age);
        }
    }
}
