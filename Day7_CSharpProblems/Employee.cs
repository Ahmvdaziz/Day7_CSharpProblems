using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_CSharpProblems
{
    struct Employee
    {
        public string name;
        public int salary;
        public Role role;
        public void Display()
        {
            Console.WriteLine($"{name }{salary}{role}");
        }
        public void AssignRole(Role role)
        {
            role |= role;           
        }
        public bool hasRole(Role r) {
            return (role & r) == role;
        }
    }
}
