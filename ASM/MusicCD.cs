using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
  public class MusicCD : Item
    {
        public string artist;
        public MusicCD() { }
        public MusicCD(string title, int yearPublished, int price, string artist)
        {
            this.title = title;
            this.yearPublished = yearPublished;
            this.price = price;
            this.artist = artist;
        }
        public override void display()
        {
            Console.WriteLine($"MusicCD\ntitle: {title} \nyearPublished: {yearPublished} \nprice: {price}" +
                $"\nartist: {artist}");
        }
    }


}
