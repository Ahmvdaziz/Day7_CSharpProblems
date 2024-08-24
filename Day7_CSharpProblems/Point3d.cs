using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day7_CSharpProblems
{
    class Point3d
    {
        public int X;
        public int Y; 
        public int Z;
        public Point3d()
        {

        }
        public Point3d (int x):this()
        {

        }
        public Point3d(int x, int y) {
        this.X = x;
            this.Y = y;
        }
        public Point3d(int x, int y, int z) : this(x, y)
        {
            Z = z;
        }

        //    public int x;
        //    int y;
        //   // defult alwyes in 
        //    // havd parmetarless constracto; have defult values
        //    public Point3d(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //        // لازم اعمل intial for all members plllz
        //    }
        //    // i canat do parmeter less constractor
        //}
        public void Display()
        {
            Console.WriteLine($"Point coordinates: (X: {X}, Y: {Y}, Z: {Z})");
        }
        public static bool operator==(Point3d p1, Point3d p2)
        {
            return p1.X == p2.X;
        }
        public  static bool operator !=(Point3d p1,Point3d p2) { 
        
        return !(p1 == p2); 
        }

    }
}
