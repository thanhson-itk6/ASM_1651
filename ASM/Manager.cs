using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public class Manager : User
    {
        private int salary;
        public int Salary { get => salary; set => salary = value; }
        public Manager() { }
        public Manager(int id, string fullName, string phoneNumber, string address, int salary)
        {
            this.Id = id;
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Salary = salary;
        }

        public override void showInfo()
        {
            Console.WriteLine($"id: {Id} \nFull Name: {FullName} \nPhone Number: {PhoneNumber}" +
                        $"\nAddress: {Address}\nSalary: {salary}");
        }
        public List<Item> deleteItem(List<Item> itemlist)
        {
            Console.WriteLine("Title of item you want to delete:");
            string title = Console.ReadLine();
            for (int i = 0; i < itemlist.Count; i++)
            {
                if (itemlist[i].title.Equals(title))
                { itemlist.RemoveAt(i); i--; }
            }
            return itemlist;
        }
        public void viewAllItem(List<Item> itemlist)
        {
            Console.WriteLine("LIST OF ALL ITEMS");
            Console.WriteLine("--------------");
            foreach (var item in itemlist)
            {
                item.display();
                Console.WriteLine("--------------");
            }
        }
        public List<Item> addItem(List<Item> itemlist)
        {
            try
            {
                Console.Write("What type of item? (Book,MusicCD,Software): ");
                string type = Console.ReadLine();
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Year Published: ");
                int yearPublished = int.Parse(Console.ReadLine());
                Console.Write("Price: ");
                int price = int.Parse(Console.ReadLine());
                if (type.Equals("book", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.Write("Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Edition: ");
                    int edition = int.Parse(Console.ReadLine());
                    itemlist.Add(new Book(title, yearPublished, price, author, edition));
                }
                else if (type.Equals("musiccd", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.Write("Artist: ");
                    string artist = Console.ReadLine();
                    itemlist.Add(new MusicCD(title, yearPublished, price, artist));
                }
                else if (type.Equals("software", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.Write("version: ");
                    string version = Console.ReadLine();
                    itemlist.Add(new Software(title, yearPublished, price, version));
                }
                else throw new("loi");
            }
            catch { Console.WriteLine("Please Try Again"); }
            return itemlist;
        }
    }
}
