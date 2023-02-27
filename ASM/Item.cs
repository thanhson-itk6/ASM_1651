using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
   public class Item
    {
        public string title;
        public int yearPublished;
        public int price;
        public Item() { }
        public virtual void display()
        {
            Console.WriteLine($"title: {title} \nyearPublished: {yearPublished} \nprice: {price}");
        }
    }
}
