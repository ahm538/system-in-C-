using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shopping
{
    public class Custmor:human
    {

        public void CustmorData() //بيانات الزبائن
        {
            Console.WriteLine("This your receipt");
            Console.WriteLine($"The name of custmor: {Name}");
            Console.WriteLine($" Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"The temporary ID : {ID}");
        }
    }
}
