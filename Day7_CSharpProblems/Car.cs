using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_CSharpProblems
{
    class Car
    {
        public int id;
        public string name;
        public Car() : this(1, "ss")
        {
            //  id = 6;
        }
        public Car(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Car(int z)
        {
        }
    }
}
