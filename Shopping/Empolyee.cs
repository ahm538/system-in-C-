using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal class Employee : human
    {
        public double Salary { get; set; }
        public double Bonus { get; set; }
        public double Deduction { get; set; }

        public Employee(string name, int id, int age, int phone)
        {
            Name = name;
            ID = id;
            Age = age;
            Phone = phone;
        }

        public void SetBonusAndDeduction(double bonus, double deduction) //عشان تحسب السالارى بعد الخصم والزيادة
        {
            Bonus = bonus;
            Deduction = deduction;
            Salary = 4000 + 20 * (Bonus - Deduction > 0 ? Bonus - Deduction : 0 - (Bonus - Deduction));
        }

        public void Print() // الطباعة بتاعة الموظفين 
        {
            
            Console.WriteLine($"This month you worked hard and earned about {Bonus*20} pound bonus");
            Console.WriteLine($"We deducted about {Deduction*20} pound ");
            Console.WriteLine($"This is your salary for this month {Salary}");
        }

        public void Print2() {
        Console.WriteLine($"Hello {Name}");
            Console.WriteLine($"Your number is: {Phone} ");
        }
        public void services() //الحاجات اللى الموظف هيختار منها
        {
            Console.WriteLine("If you want to :  ");
            Console.WriteLine("1- view your data click 1 ");
            Console.WriteLine("2-add items click 2  ");
            Console.WriteLine("3-remove items click 3");
            Console.WriteLine("4-make a transtion 4");

        }

    }
}

