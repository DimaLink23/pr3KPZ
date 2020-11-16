using System;
using System.Collections.Generic;
using System.Text;

namespace WorkLibrary
{
    public class Worker
    {

        private string Name;
        private int Year;
        private int Month;
        private Company WorkPlace;


        public Company workPlace { get { return WorkPlace; } set { WorkPlace = value; } }
        public Worker()
        { workPlace = new Company(); }
        public Worker(string NameC, string Position, int Salary, string Name, int Year, int Month)
        {

            this.Name = Name;
            this.Year = Year;
            this.Month = Month;
            WorkPlace = new Company(NameC, Position, Salary);

        }


        public Worker(string n)
        {
            Name = n;
        }



        public void Temp()
        {
            Console.WriteLine("Введіть рік прийняття працівника на роботу : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть місяць : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Year = a;
            Month = b;

        }

        ///Властивості
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }


        public interface ICloneable
        {
            object Clone();
        }

        public void GetTotalExperience()
        {
            DateTime date1 = DateTime.Now;

            DateTime date2 = new DateTime(Year, Month, 1);

            int YearExperience = date1.Year - date2.Year;
            int MonthExperience = date1.Month - date2.Month;
            Console.WriteLine($"Працівник був на роботі з");
            Console.WriteLine(YearExperience);
            Console.WriteLine("  років ");
            Console.WriteLine(" або  ");
            Console.WriteLine(YearExperience * 12 + MonthExperience);
            Console.WriteLine(" місяців  ");
        }
        public void GetTotalMoney()
        {

            DateTime date1 = DateTime.Now;

            DateTime date2 = new DateTime(Year, Month, 1);

            int YearExperience = date1.Year - date2.Year;
            int MonthExperience = date1.Month - date2.Month;
            Console.WriteLine($"Працівник отримав за всі місяці роботи");

            Console.WriteLine((YearExperience * 12 + MonthExperience) * WorkPlace.salary);
            Console.WriteLine(" грн. ");
        }
        public void PrintWorker()
        {
            Console.WriteLine(workPlace._name);
            Console.WriteLine(workPlace._position);
            Console.WriteLine(workPlace._salary);
            Console.WriteLine("Імя :");
            Console.WriteLine(Name);
            Console.WriteLine("Рік прийняття :");
            Console.WriteLine(Year);
            Console.WriteLine("Місяць : ");
            Console.WriteLine(Month);
        }
        public void PrintWorkers()
        {
            Console.WriteLine("Імя :");
            Console.WriteLine(WorkPlace._name);
            Console.WriteLine("Імя :");
            Console.WriteLine(Name);
            Console.WriteLine("Рік прийняття :");
            Console.WriteLine(Year);
            Console.WriteLine("Місяць : ");
            Console.WriteLine(Month);
        }
        public void ReadWorkersArray()
        {

            Console.WriteLine("Імя :");
            Name = Console.ReadLine();
            Console.WriteLine("Рік прийняття :");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Місяць : ");
            Month = Convert.ToInt32(Console.ReadLine());

            ///   public void ReadWorkersArray() {
            ///  Console.WriteLine("Введіть кількість людей яких вам потрібно ввести >>>");
            ///   int i = Convert.ToInt32(Console.ReadLine());

            ///    for (int j=0; j < i;j++) {
            ///          Console.WriteLine("Імя :");
            ///    Name = Console.ReadLine();
            ///    Console.WriteLine("Рік прийняття :");
            ///    Year = Convert.ToInt32(Console.ReadLine());
            ///     Console.WriteLine("Місяць : ");
            //     Month = Convert.ToInt32(Console.ReadLine());
            ///    }



        }

    }
}
