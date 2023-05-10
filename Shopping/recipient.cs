using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal class recipient
    {
        public string customername { get; set; }
        public string employeename { get; set; }

        public double quantity { get; set; }
        public double price { set; get; }

        public void totalprice()
        {
            double sum = 0;
            double prod;
            if (quantity != 1)
            {
                prod = price * quantity;
            }
            else { prod = price; }
            sum += prod;

            Console.WriteLine(sum);
            Console.WriteLine("Do you want to add item?");
            string x = Console.ReadLine();
            //while (x == "yes" || x == "Yes")
            //{//return to code mohamed 
        }

        public recipient(string customername, string employeename, double quantity, double price)
        {
            this.customername = customername;
            this.employeename = employeename;
            this.quantity = quantity;
            this.price = price;


        }
        public recipient()
        {
             
        }


    }
    

       
    
}
