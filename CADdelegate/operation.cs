using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADdelegate
{
    public delegate void ope(int x, int y);
    public class operation
    {
        public void Add(int x, int y)
        {

            Console.WriteLine($" {x} + {y} = {x + y} ");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($" {x} - {y} = {x - y} ");
        }
        public void Multi(int x, int y)
        {
            Console.WriteLine($" {x} * {y} = {x * y} ");

        }
    }
}
