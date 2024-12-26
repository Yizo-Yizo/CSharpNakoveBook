using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    // Ch 14 No. 14
    public class GSMTest
    {
        public void PrintMobilePhones()
        {
            MobilePhone[] mobilePhones = new MobilePhone[]
            {
            new MobilePhone("Nokia"),
            new MobilePhone("Samsung"),
            new MobilePhone("iPhone"),
            MobilePhone.NokiaN95 // Include the Nokia N95
            };

            foreach (MobilePhone phone in mobilePhones)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine(); // For spacing between different phones
            }
        }
    }
}
