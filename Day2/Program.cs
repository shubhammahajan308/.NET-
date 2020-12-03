using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager("RAM SHUKLA",1,"Manager");
            Employee e2 = new GeneralManager("shiv ", 2, "GM",20000);
            Employee e3 = new CEO();
            e1.Basic1 = 45000;
            Console.WriteLine(e1.ENo);
            Console.WriteLine(e1.Dept_No);
            Console.WriteLine(e1.Ename);
            Console.WriteLine(e1.Basic1);
            Console.WriteLine(e1.CalcNetSalary());
            Console.ReadLine();

            e2.Basic1 = 60000;  
            Console.WriteLine(e2.ENo);
            Console.WriteLine(e2.Dept_No);
            Console.WriteLine(e2.Ename);
            Console.WriteLine(e2.Basic1);
            Console.WriteLine(e2.CalcNetSalary());
            Console.ReadLine();

            e3.Basic1 = 1500000;
            Console.WriteLine(e3.ENo);
            Console.WriteLine(e3.CalcNetSalary());
            Console.ReadLine();
        }
    }
   public abstract class Employee
    {
        private static int  lastEmpno=0;
      public  Employee(string Name = "Noname",short DeptNo=0)
        {
            lastEmpno++;
            this.EmpNo = lastEmpno;
            this.Name = Name;
            this.DeptNo = DeptNo;

        }
        private string Name;
        public string Ename
        {
            set
            {
                if (Name != null || Name != "")
                    Name = value;
                else
                    Console.WriteLine("Invalid name");

            }
            get
            {
                return Name;
            }
        }

        private int EmpNo;

        public int ENo
        {
            get
            {
                return EmpNo;
            }
        }

        private short DeptNo;
            public short Dept_No
        {
            set
            {
                if (DeptNo > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("Inavlid Deptno");
            }
            get
            {
                return DeptNo;
            }
        }
        protected decimal Basic;
        abstract public decimal Basic1 {
            get;
            set;

        }
        abstract public decimal CalcNetSalary();
    }

   public class Manager : Employee
    {
        public Manager(string Name = "Noname",  short DeptNo = 0,string  designation="None"):base(Name,DeptNo)
        {
            this.designation = designation;
        }
        private string designation;
        public string Designation
        {
            set
            {
                if (designation != null && designation != "")
                    designation = value;
                else
                    Console.WriteLine("Invalid Designation");
            }
            get
            {
                return designation;
            }
        }
        public override decimal Basic1
        {
            get { 
                return Basic; 
            }
            set {
                Basic = value;
            }

        }

        public override decimal CalcNetSalary()
        {
            decimal da = 0.4M * Basic1;
            decimal NetSalary = Basic1 + da;
            return NetSalary;

        }
    }
    public class GeneralManager : Manager
    {
       
        public GeneralManager(string Name = "Noname",  short DeptNo = 0, string designation = "None",int Perks=10000):base(Name,DeptNo,designation)
        {
            this.Perks = Perks;
        }
        private int Perks;
        public int  Perks_
        {
            set
            {
                Perks = value;
            }
            get
            {
                return Perks;
            }
        }
        public override decimal CalcNetSalary()
        {
            decimal da = 0.4M * Basic1;
            decimal NetSalary = Basic1 + da+ Perks_;
            return NetSalary;

        }
    }
    public class CEO : Employee
    {
        public CEO(string Name = "DESHAW", short DeptNo = 0):base(Name,DeptNo)
        {
        

        }
        public override decimal Basic1
        {
            get
            {
                return Basic;
            }
            set
            {
                Basic = value;
            }
        }
         public sealed override  decimal CalcNetSalary()
        {
            decimal da = 0.4M * Basic1;
            decimal NetSalary = Basic1 + da;
            return NetSalary;

        }

    }
}
