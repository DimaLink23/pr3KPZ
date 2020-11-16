using System;

namespace WorkLibrary
{
   public class Company
    {
        private string Name;
        private string Position;
        private int Salary;

        public Company()
        { }

        public Company(string Name, string Position, int Salary)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = Salary;
        }

        public string _name { set { Name = value; } get { return Name; } }
        public string _position { set { Position = value; } get { return Position; } }
        public int _salary { set { Salary = value; } get { return Salary; } }
        public Company(string n)
        {
            Name = n;
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
        public string position
        {
            get
            {
                return Position;
            }

            set
            {
                Position = value;
            }
        }
        public int salary
        {

            get
            {
                return Salary;
            }

            set
            {
                Salary = value;
            }
        }

        public void PrintCompany()
        {
            Console.WriteLine("Компанія :");
            Console.WriteLine(Name);
            Console.WriteLine("Посада :");
            Console.WriteLine(Position);
            Console.WriteLine("Зарплата : ");
            Console.WriteLine(Salary);
        }

        public interface ICloneable
        {
            object Clone();
        }
    }
}

