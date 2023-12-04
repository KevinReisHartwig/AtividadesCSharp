using System;
using AtividadeEnum.Entities.Enums;
using System.Globalization;
using AtividadeEnum.Entities;

namespace AtividadeEnum {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker date: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WokerLevel level = (WokerLevel)Enum.Parse(typeof(WokerLevel), Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);
            Woker woker = new Woker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write($"Enter #{i} contract date:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);

                woker.AddContract(contract);



            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + woker.Name);
            Console.WriteLine("Department: " + woker.Departmant.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + woker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
