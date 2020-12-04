using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InheritanceExampleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager("RAM SHUKLA", 1, "Manager");
            Employee e2 = new GeneralManager("shiv ", 2, "GM", 20000);
            Employee e3 = new CEO();

            e1.Basic1 = 40000;
            Console.WriteLine(e1.CalcNetSalary());
            e1.DesignationName();
            e1.role();
            Console.ReadLine();


            e2.Basic1 = 65000;
            Console.WriteLine(e2.CalcNetSalary());
            e2.DesignationName();
            e2.role();
            Console.ReadLine();

            e3.Basic1 = 150000;
            Console.WriteLine(e3.CalcNetSalary());
            e3.DesignationName();
            e3.role();
            Console.ReadLine();
        }
    }
    public interface IDbFunctions
    {
        void DesignationName();
        void role();
    }
    public abstract class Employee :IDbFunctions
    {
        private static int lastEmpno = 0;
        public Employee(string Name = "Noname", short DeptNo = 0)
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
        abstract public decimal Basic1
        {
            get;
            set;

        }
        abstract public decimal CalcNetSalary();

        public virtual void DesignationName()
        {
            Console.WriteLine("Designation is employee");
        }

        public virtual void role()
        {
            Console.WriteLine("role is employee");
        }
    }

    public class Manager : Employee,IDbFunctions
    {
        public Manager(string Name = "Noname", short DeptNo = 0, string designation = "None") : base(Name, DeptNo)
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
            get
            {
                return Basic;
            }
            set
            {
                Basic = value;
            }

        }

        public override decimal CalcNetSalary()
        {
            decimal da = 0.4M * Basic1;
            decimal NetSalary = Basic1 + da;
            return NetSalary;

        }
        public override void DesignationName()
        {
            Console.WriteLine("Designation is Manager");
        }

        public override void role()
        {
            Console.WriteLine("role is Manager");
        }
    }
    public class GeneralManager : Manager
    {

        public GeneralManager(string Name = "Noname", short DeptNo = 0, string designation = "None", int Perks = 10000) : base(Name, DeptNo, designation)
        {
            this.Perks = Perks;
        }
        private int Perks;
        public int Perks_
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
            decimal NetSalary = Basic1 + da + Perks_;
            return NetSalary;

        }
        public override void DesignationName()
        {
            Console.WriteLine("Designation is GM");
        }

        public override void role()
        {
            Console.WriteLine("role is GM");
        }

    }
    public class CEO : Employee
    {
        public CEO(string Name = "DESHAW", short DeptNo = 0) : base(Name, DeptNo)
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
        public sealed override decimal CalcNetSalary()
        {
            decimal da = 0.4M * Basic1;
            decimal NetSalary = Basic1 + da;
            return NetSalary;

        }
        public sealed override void DesignationName()
        {
            Console.WriteLine("Designation is CEO");
        }

        public sealed override void role()
        {
            Console.WriteLine("role is CEO");
        }

    }
}

