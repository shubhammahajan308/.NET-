using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.ReadLine();

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.ReadLine();

            Console.WriteLine(o1.GetNetSalary());
            Console.WriteLine(o2.GetNetSalary());
            Console.WriteLine(o3.GetNetSalary());
            Console.WriteLine(o4.GetNetSalary());

            Console.ReadLine();
        }
    }
    class Employee
    {
        //properties
        private string name = null;
        public string Name
        {
            set
            {
                if (name != "" || name != null)
                    name = value;
                else
                    Console.WriteLine("Inavlid name ");
            }
            get
            {
                return name;
            }
        }
        private int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        private decimal basic = 0;
        public decimal Basic
        {
            set
            {
                if (basic < 200000 && basic > 100000)
                    basic = value;
                else
                    Console.WriteLine("Invalid basic amount");
            }
            get
            {
                return basic;
            }
        }
        private int deptno;
        public int DeptNo
        {
            set
            {
                if (deptno > 0)
                    deptno = value;
                else
                    Console.WriteLine("Invalid deptno");
            }
            get
            {
                return deptno;
            }
        }

        
        static int count;
        public Employee(string name=null,decimal basic=0,short deptno=0)
        {
            Employee.count++;
            this.empNo = Employee.count;
            this.basic = basic;
            this.name = name;
            this.deptno = deptno;
        }
        public decimal GetNetSalary()
        {
             decimal da = 0.30M * basic;
            decimal hra = 0.2M * basic;
            decimal netSalary = basic + da + hra;
            return netSalary;
        }
    }

}
