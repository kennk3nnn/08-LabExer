using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public abstract class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }

        public Employee(string FirstName, string LastName, string Department, string JobTitle)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Department = Department;
            this.JobTitle = JobTitle;
        }

        public abstract decimal CalculateSalary();

        public virtual void DisplaySalary()
        {
            Console.WriteLine("=== EMPLOYEE MANAGEMENT SYSTEM ===");
            Console.WriteLine("---Employee Salary Information---");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Job Title: {JobTitle}");
            Console.WriteLine($"Calculated Salary: {CalculateSalary():C}");
        }

        public class FullTimeEmployee : Employee
        {
            public decimal MonthlySalary { get; set; }

            public FullTimeEmployee(string FirstName, string LastName, string Department, string JobTitle, decimal MonthlySalary) : base(FirstName, LastName, Department, JobTitle)
            {
                this.MonthlySalary = MonthlySalary;

            }
            public override decimal CalculateSalary()
            {
                return MonthlySalary * 12;
            }
            public override void DisplaySalary()
            {
                base.DisplaySalary();
                Console.WriteLine("Salary Calculation: FullTimeEmployee = Monthly salary x 12");
                Console.WriteLine(new string('-', 40));
            }



            public class PartTimeEmployee : Employee
            {
                public decimal RatePerHour { get; set; }
                public int TotalHoursWorked { get; set; }

                public PartTimeEmployee(string FirstName, string LastName, string Department, string JobTitle, decimal RatePerHour) : base(FirstName, LastName, Department, JobTitle)
                {
                    this.RatePerHour = RatePerHour;
                    this.TotalHoursWorked = 0;
                }
                public void AddHours(int hours)
                {
                    TotalHoursWorked += hours;
                }

                public override decimal CalculateSalary()
                {
                    return TotalHoursWorked * RatePerHour;
                }

                public override void DisplaySalary()
                {
                    base.DisplaySalary();
                    Console.WriteLine($"Rate per Hour: {RatePerHour}");
                    Console.WriteLine($"Hours Worked: {TotalHoursWorked}");
                    Console.WriteLine("Salary Calculation: PartTimeEmployee = Hours worked x Hourly rate");
                    Console.WriteLine(new string('-', 40));
                }

            }

            public class Intern : Employee
            {
                public decimal MonthlyStipend { get; set; }

                public Intern(string FirstName, string LastName, string Department, string JobTitle, decimal MonthlyStipend) : base(FirstName, LastName, Department, JobTitle)
                {
                    this.MonthlyStipend = MonthlyStipend;
                }
                public override decimal CalculateSalary()
                {
                    return MonthlyStipend;
                }

                public override void DisplaySalary()
                {
                    base.DisplaySalary();
                    Console.WriteLine("Salary Calculation: Intern = Monthly Stipend");
                    Console.WriteLine(new string('-', 40));
                }
            }

            public class ContractEmployee : Employee
            {
                public decimal RatePerHour { get; set; }
                public int TotalHoursWorked { get; set; }

                public ContractEmployee(string FirstName, string LastName, string Department, string JobTitle, decimal RatePerHour) : base(FirstName, LastName, Department, JobTitle)
                {
                    this.RatePerHour = RatePerHour;
                    this.TotalHoursWorked = 0;
                }
                public void AddHours(int hours)
                {
                    TotalHoursWorked += hours;
                }

                public override decimal CalculateSalary()
                {
                    return TotalHoursWorked * RatePerHour;
                }

                public override void DisplaySalary()
                {
                    base.DisplaySalary();
                    Console.WriteLine($"Rate per Hour: {RatePerHour}");
                    Console.WriteLine($"Hours Worked: {TotalHoursWorked}");
                    Console.WriteLine("Salary Calculation: ContractEmployee = Hours worked x Hourly rate");
                    Console.WriteLine(new string('-', 40));
                }

            }

        }
    }
}
