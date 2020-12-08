using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> SimpleInterest = (P, N, R) => { return (P * R * N / 100); };
            Func<int, int, bool> IsGreater = (a, b) => { return a > b; };
            Func<Employee, decimal> GetBasic = emp1 => { return emp1.BasicSal; };
            Func<Employee, bool> IsGreaterThan10000 = emp => { return emp.BasicSal > 10000; };
            Func<int, bool> IsEven = (a) => { return a % 2 == 0; };
            Employee e = new Employee { BasicSal = 10000 };

            Console.WriteLine("simple interst is {0}",SimpleInterest(100,2,8));
            Console.WriteLine("a is greater than b is {0}",IsGreater(56,32));
            Console.WriteLine("basic salary of employee is {0}",GetBasic(e));
            Console.WriteLine("Given nos is even or not : {0}",IsEven(12));
            Console.ReadLine();
            Console.WriteLine(IsGreaterThan10000(e));
            Console.ReadLine();

        }
    }
    class Employee
    {
        public int BasicSal;
        public Employee()
        {
                
        }
    }
}
