using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();

            Console.WriteLine("Welcome, dear user ");
            Console.WriteLine("If you are an employee, click: 1 ");
            Console.WriteLine("If you are a customer, click: 2");
            int CheckUser = int.Parse(Console.ReadLine());


            if (CheckUser == 1) // تحدديد نوع المستخدم 
            {


                Console.WriteLine("Hello my Employee, please enter your id: ");
                Console.WriteLine("");
                int id = int.Parse(Console.ReadLine());

                Employee[] employees = new Employee[] // بيانات الموظفين
                {
                  new Employee("Ahmed Essam",1,25,012541),
                  new Employee("Mohamed Ali", 2, 26, 011487),
                  new Employee("Nouran Amin", 3, 20,012589),
                  new Employee("Fatma abuelfadel ", 4, 24, 011789),
                  new Employee("Zyad Atef", 5, 25, 012875)
                };
                Employee employee = employees.FirstOrDefault(emp => emp.ID == id);// بيدور ع الايدى المكتوب وبناء عليه بيستدعى البيانات 
                if (employee == null)
                {
                    Console.WriteLine("Invalid ID");
                    return;
                }

                employee.services();
                int AccessFromEmployees = int.Parse(Console.ReadLine());

                // انواع الخدمات المتاحة للموظف
                if (AccessFromEmployees == 1)  // عرض البيانات
                {
                    Console.WriteLine("this is your data: ");


                    Console.WriteLine("Please enter the number of additional hours you worked");
                    double bonus = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the number of hours you did not work");
                    double deduction = double.Parse(Console.ReadLine());

                    employee.SetBonusAndDeduction(bonus, deduction);
                    employee.Print2();
                    employee.Print();
                }


                else if (AccessFromEmployees == 2) //عرض المنتجات 
                { Console.WriteLine("add items ");
                    item.addItem();
                }
               

                else if (AccessFromEmployees == 3) //حذف عنصر
                { Console.WriteLine("remove items");
                item.removeItems(); 
                }

                else if (AccessFromEmployees == 4) //خاص بالفاتورة 
                {
                   
                    recipient r1 = new recipient();
                    
                     employee.Print2();

                    Console.Write("Enter customer name: ");
                    r1.customername = Console.ReadLine();
                   
                    Console.WriteLine("Enter the code of item");
                    item.id =int.Parse(Console.ReadLine());
                    Console.Write("Enter Quantity of product: ");
                    item.quantity =int.Parse(Console.ReadLine());

                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("\n" + DateTime.Now.ToString()); // print the date and time
                    Console.WriteLine("Your Recipit ");
                    Console.WriteLine("\nCustomer name: " + r1.customername);
                    Console.WriteLine("\nEmployee name: " + employee.Name);
                    Console.WriteLine("the item  ");
                    Console.Write("\nTotal price: ");
                    r1.totalprice();
                   item.displayItems();  
                    Console.WriteLine("We hope you enjoy with us");
                }


            }



            else if (CheckUser == 2) // خاص بالزبون 
            {
                Console.WriteLine("Welcome dear,custmor");
                Custmor cu1 = new Custmor();
                Console.WriteLine("Pleaze enter your name: ");
                cu1.Name = Console.ReadLine();
                Console.WriteLine("Pleaze enter your phone: ");
                cu1.Phone = int.Parse(Console.ReadLine());
                Console.WriteLine("Pleaze enter your age: ");
                cu1.Age = int.Parse(Console.ReadLine());
                cu1.ID = cu1.Phone * 3 / 11;

                Console.WriteLine("Pleaze enter the numper of elemments: ");
                int NumperOfElements = int.Parse(Console.ReadLine());
                string[] Sales = new string[NumperOfElements];

                for (int i = 0; i < Sales.Length; i++) // عشان تدخل المنتجات اللى اشترتها 
                {
                    Console.Write("Enter Elemnt {0}: ", i + 1);
                    Sales[i] = Console.ReadLine();
                }

                string mostCommon = ""; //عشان تشوف اكتر واحد اتكرر
                int count = 0;
                for (int i = 0; i < Sales.Length; i++)
                {
                    int currentCount = 0;
                    for (int j = 0; j < Sales.Length; j++)
                    {
                        if (Sales[j] == Sales[i])
                        {
                            currentCount++;
                        }
                    }
                    if (currentCount > count)
                    {
                        count = currentCount;
                        mostCommon = Sales[i];

                    }

                }

                Console.WriteLine($"You have a 2% discount on {mostCommon}");

                Console.WriteLine($" we have offers on {mostCommon} that you might like to see");
                cu1.CustmorData();
            }
            else
            {
                Console.WriteLine("Invaid numper,Please chose 1 or 2 ");
                return;
            }


        }

    }
    }

