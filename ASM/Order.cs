using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
   public class Order
    {
        public DateTime date;
        public List<Item> items = new List<Item>();
        public Customer customer;
        public int total;
        public Payment paymentMethod;
        public Order(DateTime date, Customer customer)
        {
            this.customer = customer;
            this.date = date;
        }
        public void addItem(List<Item> itemlist, string title)
        {
            foreach (var item in itemlist)
                if (item.title.Equals(title))
                    items.Add(item);
            calcTotal();
        }
        public void calcTotal()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.price;
            }
            this.total = total;
        }
        public void selectPaymentMethod()
        {
            Console.Write($"The amount to be paid is:{total}\n What is your payment Method? (Credit/Cash): ");
            string pm = Console.ReadLine();
            if (pm.Equals("credit", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.Write("Card Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Type of your Card: ");
                string type = Console.ReadLine();
                Console.Write("Expiration date(dd-MM-yyyy): ");
                string expdate = Console.ReadLine();
                paymentMethod = new Credit(number, type, expdate, total);
            }
            else if (pm.Equals("cash", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.Write("Cash: ");
                int number = int.Parse(Console.ReadLine());
                paymentMethod = new Cash(number, total);
            }
            else throw new("Payment method ERROR");
        }

        public override string? ToString()
        {
            string str = "";
            foreach (var item in items)
            {
                str += item.title + ", ";
            }
            return $"Customer name:{customer.FullName}\nitems:{str}\nPayment: {paymentMethod}";
        }
    }
}
