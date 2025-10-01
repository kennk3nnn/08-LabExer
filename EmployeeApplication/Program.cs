using EmployeeManagementSystem;
using static EmployeeManagementSystem.Employee;

public class Program
{
    public static void Main(string[] args)
    {
        IEmployee fullTime = new FullTimeEmployee("John", "Doe", "IT", "Software Engineer", 5000);
        fullTime.DisplaySalary();

        IEmployee partTime = new FullTimeEmployee.PartTimeEmployee("Marvin", "Hemmings", "Operations", "Warehouse Supervisor", 20);
        ((FullTimeEmployee.PartTimeEmployee)partTime).AddHours(120);
        partTime.DisplaySalary();

        IEmployee intern = new FullTimeEmployee.Intern("Jenny", "Meyers", "Finance", "Bookkeeper", 1000);
        intern.DisplaySalary();

        IEmployee contract = new FullTimeEmployee.ContractEmployee("Bob", "Lee", "Sales", "Sales Manager", 50);
        ((FullTimeEmployee.ContractEmployee)contract).AddHours(100);
        contract.DisplaySalary();
    }
}