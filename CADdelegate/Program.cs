using CADdelegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee {Id=1,Name="Sayed", Gender="M",TotalSalary=50000},
                new Employee {Id=2,Name="ALi", Gender="F",TotalSalary=10000},
                new Employee {Id=3,Name="Alaa", Gender="F",TotalSalary=4000},
                new Employee {Id=4,Name="Heba", Gender="F",TotalSalary=50000},
                new Employee {Id=5,Name="Muhammed", Gender="M",TotalSalary=80900},
                new Employee {Id=6,Name="Mohsen", Gender="M",TotalSalary=80000}
            };
            report report = new report();
            report.procssEmployee(emps, "bigger Than 60000", e => e.TotalSalary >= 60000);
            report.procssEmployee(emps, "less Than 60000", e => e.TotalSalary < 60000);
            report.procssEmployee(emps, "less Than 60000 & Bigger Than 30000", e => e.TotalSalary < 60000 && e.TotalSalary >= 30000);
            Console.WriteLine("###################################################");
            operation operation = new operation();
            ope ope = operation.Add;
            ope += operation.Sub;
            ope += operation.Multi;
            ope(5, 10);
            Console.WriteLine("#################################################33");
            rectangle rectangle = new rectangle();
            rectDelegate rect = rectangle.getArea;
            rect += rectangle.getPrimeter;
            rect(2, 50);
        }
        //    static bool biggerThan60000(Employee e) => e.TotalSalary >= 60000;
        //    static bool lessThan60000(Employee e) => e.TotalSalary < 60000;
        //    static bool between30000And60000(Employee e) => e.TotalSalary >= 30000&& e.TotalSalary<59999;
    }
}
