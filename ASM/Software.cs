using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
   public class Software : Item
    {
        public string version;
        public Software() { }
        public Software(string title, int yearPublished, int price, string version)
        {
            this.title = title;
            this.yearPublished = yearPublished;
            this.price = price;
            this.version = version;
        }
        public override void display()
        {
            Console.WriteLine($"Software\ntitle: {title} \nyearPublished: {yearPublished} \nprice: {price}" +
                $"\nversion: {version}");
        }
    }
}
