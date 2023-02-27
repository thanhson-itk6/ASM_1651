using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public static class StringExtensions
    {
        public static bool ContainsCaseInsensitive(this string source, string substring)
        {
            return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }
    public class Customer : User
    {
        public Customer()
        {
            Console.WriteLine("PLEASE PROVIDE INFORMATION");
            Console.Write("Id: ");
            this.Id = int.Parse(Console.ReadLine());
            Console.Write("FullName: ");
            this.FullName = Console.ReadLine();
            Console.Write("PhoneNumber: ");
            this.PhoneNumber = Console.ReadLine();
            Console.Write("Address: ");
            this.Address = Console.ReadLine();
        }
        public Customer(int id, string fullName, string phoneNumber, string address)
        {
            this.Id = id;
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }
        public override void showInfo()
        {
            Console.WriteLine($"id: {Id} \nFull Name: {FullName} \nPhone Number: {PhoneNumber}" +
                        $"\nAddress: {Address}");
        }
        public void searchItemByTitle(List<Item> itemlist)
        {
            Boolean check = false;
            Console.WriteLine("What item are you looking for? ");
            var title = Console.ReadLine();
            foreach (var item in itemlist)
            {
                if (item.title.ContainsCaseInsensitive(title))
                {
                    item.display(); check = true;
                    Console.WriteLine("--------------");
                }
            }
            if (check == false) Console.WriteLine("Nothing Found");
        }
    }
}
