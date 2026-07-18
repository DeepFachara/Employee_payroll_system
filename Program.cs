using System;

namespace EmployeePayroll

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Choose Employee Type:");

            Console.WriteLine("1. Full-Time Employee");

            Console.WriteLine("2. Part-Time Employee");

            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            Employee e1 = null;

            if (choice == 1)

            {

                e1 = new FullTime();

            }

            else if (choice == 2)

            {

                e1 = new PartTime();

            }

            else

            {

                Console.WriteLine("Invalid Choice!");

                return;

            }

            e1.AcceptDetails();

            Console.WriteLine();

            e1.DisplayDetails();

            e1.SalaryCalculate();

            Console.ReadKey();

        }

    }

    public class Employee

    {

        public int empId;

        public string empName;

        public double basicSalary;



        public void AcceptDetails()

        {

            Console.Write("Enter Employee ID: ");

            empId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");

            empName = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");

            basicSalary = Convert.ToDouble(Console.ReadLine());

        }

        public void DisplayDetails()

        {

            Console.WriteLine("\nEmployee Details");

            Console.WriteLine("----------------------");

            Console.WriteLine("Employee ID   : ", empId);

            Console.WriteLine("Employee Name : ", empName);

            Console.WriteLine("Basic Salary  : ", basicSalary);

        }

        public virtual void SalaryCalculate()

        {

        }

    }

    public class FullTime : Employee

    {

        public override void SalaryCalculate()

        {

            double DA = basicSalary * 0.20;

            double HRA = basicSalary * 0.10;

            double netSalary = basicSalary + DA + HRA;

            Console.WriteLine("\nEmployee Type : Full-Time");



            Console.WriteLine("Net Salary    : ", netSalary);

        }

    }

    public class PartTime : Employee

    {

        public override void SalaryCalculate()

        {

            double netSalary = basicSalary;

            Console.WriteLine("\nEmployee Type : Part-Time");

            Console.WriteLine("Net Salary    : ", netSalary);

        }

    }

}