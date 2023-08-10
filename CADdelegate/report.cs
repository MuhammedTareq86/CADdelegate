using operatorOverloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADdelegate
{
    public class report {
        public delegate bool illagaleSalary(Employee e);
        public void procssEmployee(Employee[] employees, string title,illagaleSalary isIllgable)
        {
            Console.WriteLine(title);
            Console.WriteLine("**********************");

            foreach (var e in employees)
            {
                if (isIllgable(e))
                {
                    Console.WriteLine($"{e.Id}||{e.Name}||{e.Gender}||{e.TotalSalary}");
                }
            }
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^");
        }
    }
}

