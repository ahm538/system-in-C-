using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string type { get; set; }
        public int totalprice { get { return (int)(price * quantity); } }


        public Item(int id, string name, decimal price, int quantity, string type)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

        public Item() { }



        public static List<Item> items = new List<Item>();

        // method to add items
        public void addItem()
        {

            while (true)
            {
                Console.WriteLine("Do you want to add an item? (yes/no)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    Console.WriteLine("Enter the id of the item:");
                    id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the name of the item:");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter the price of the item:");
                    price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the quantity of the item:");
                    quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the type of the item:");
                    type = Console.ReadLine();

                    Item item = new Item(id, name, price, quantity, type);
                    items.Add(item);
                    Console.WriteLine("The item is added successfully.\n");
                }
                else if (answer == "no")
                {
                    displayItems();


                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.\n");
                }
            }
        }

        // method to see  all the itemes , i created it 
        public void displayItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items added yet.\n");
            }
            else
            {
                // id, name, type, quantity, price, totalprice)
                Console.WriteLine("List of items:");
                Console.WriteLine("code   " + "the Items     " + "type       " + "quantity      " + "price         " + "totalprice");

                foreach (Item item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

            }
        }

        public void removeItems()
        {

            items.Clear();
            Console.WriteLine("All the items is deleted");
        }
        // items already in system
        public void displayItems2()
        {
            string[] code = new string[6] { "m1", "m2", "m3", "m4", "m5", "m6" };
            string[] items = new string[6] { "pop corn", "choclate", "chipcy", "noodels", "pepsi", "finish trancication" };
            decimal[] price = new decimal[6] { 10.00m, 20.00m, 5.00m, 10.00m, 8.00m, 0 };
            Console.WriteLine("code".PadRight(10) + "the Items".PadRight(30) + "price");
            string strprice = "";

            for (int i = 0; i < code.Length; i++)
            {

                if (price[i] > 0) { strprice = price[i].ToString(); } else { strprice = ""; }
                Console.WriteLine(code[i].PadRight(10) + items[i].PadRight(30) + strprice);

            }

   
        }
        public override string ToString()
        {
            return ($"[{id}] >>>  {name}  >>>>>> {type}   >>>>>>  {quantity} >>>>>>> {price}$ >>>>>>>{totalprice}$  ");
            //"+ name, type, quantity, price, totalprice

        }

        


    }
}
