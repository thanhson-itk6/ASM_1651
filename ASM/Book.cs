using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
   public class Book : Item
    {
        public string author;
        public int edition;
        public Book() { }
        public Book(string title, int yearPublished, int price, string author, int edition)
        {
            this.title = title;
            this.yearPublished = yearPublished;
            this.price = price;
            this.author = author;
            this.edition = edition;
        }
        public override void display()
        {
            Console.WriteLine($"Book\ntitle: {title} \nyearPublished: {yearPublished} \nprice: {price}" +
                $"\nauthor: {author}\nedition: {edition}");
        }
    }
}
