using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookManagement addressBookManagement = new AddressBookManagement();

            addressBookManagement.DataBaseConnection(); //UC1
            Console.ReadLine();
        }
    }
}
