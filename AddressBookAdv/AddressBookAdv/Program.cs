using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookManagement addressBookManagement = new AddressBookManagement();

            // addressBookManagement.DataBaseConnection(); //UC1
            //AddressBookManagement repository = new AddressBookManagement();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Shreya";
            model.LastName = "Malviya";
            model.Address = "Mumbai";
            model.City = "Mumbai";
            model.State = "Maharashtra";
            model.Zip = 410022;
            model.PhoneNumber = 2635145678;
            model.EmailId = "shreya111@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "SHreyaM";
            //bool res = addressBookManagement.AddDataToTable(model);

            // Console.WriteLine(res);
            addressBookManagement.EditContactUsingPersonName(model);


            // addressBookManagement.GetAllContact(); //UC2
            Console.ReadLine();
        }
    }
}
