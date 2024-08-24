
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_CSharpProblems
{
    [Flags]
    enum Role
    {
        Admin = 0, Account = 1, stock = 2, Reception = 4
    }
    internal class Program
    {
        static void ChangeStringValue(string str)
        {
            str = "Goodbye, World!";
            Console.WriteLine("String inside the function: " + str);
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.AssignRole(Role.Admin);
            employee.AssignRole(Role.Account);
            employee.Display();
            Console.WriteLine(employee.hasRole(Role.Admin));
            Console.WriteLine(employee.hasRole(Role.Account));
            employee.AssignRole(Role.Reception);
            employee.Display();
            //-------------
            string originalString = "Hello, World!";
            Console.WriteLine("Original String before function call: " + originalString);

            ChangeStringValue(originalString);

            Console.WriteLine("Original String after function call: " + originalString);
            //----------------------------------
            Point3d point3D = new Point3d() {X=1,Y=2,Z=3 };
            Point3d point3D1 = new Point3d(1,2,3) ;
            point3D.Display();
            point3D1.Display();
            Console.WriteLine(point3D1 == point3D);

        }
    }
}
