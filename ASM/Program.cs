using ASM;


class Program
{
    static void Main(string[] args)
    {
        List<Item> itemlist = new List<Item>();
        List<Order> orders = new List<Order>();
        List<Customer> customers = new List<Customer>();
        itemlist.Add(new Book("Doraemon", 2002, 100, "Fujio", 1));
        //itemlist.Add(new Book("Doraemon 2", 2002, 100, "Fujio", 2));
        //itemlist.Add(new Book("Doraemon 3", 2002, 100, "Fujio", 2));
        //itemlist.Add(new Software("Photoshop", 2002, 100, "22.1"));
        //itemlist.Add(new MusicCD("Love yourself", 2022, 2, "Justin"));
        string role = "";
        do
        {
            Console.Write("role: ");
            role = Console.ReadLine();
            if (role.Equals("manager"))
            {
                Manager manager = new Manager();
                int x;
                do
                {
                    Console.WriteLine("--------------");
                    Console.WriteLine($"1:View all items\n2:Add a new item\n3:Delete item\n4:Exit");
                    Console.Write("Choose your option:");
                    x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            manager.viewAllItem(itemlist);
                            break;
                        case 2:
                            manager.addItem(itemlist);
                            break;
                        case 3:
                            manager.deleteItem(itemlist);
                            break;
                        default:
                            break;
                    }
                } while (x != 4);
            }
            else if (role.Equals("customer"))
            {
                Customer person = new Customer();
                customers.Add(person);
                Order order = new Order(DateTime.Today, person);
                Console.WriteLine(order.date);
                int x;
                do
                {
                    Console.WriteLine("--------------");
                    Console.WriteLine($"1:Search item by title\n2:ADD Item to order\n3: Print order detail\n4:Exit");
                    Console.Write("Choose your option:");
                    x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            person.searchItemByTitle(itemlist);
                            break;
                        case 2:
                            Console.WriteLine("Title of item you want to add: ");
                            string title = Console.ReadLine();
                            order.addItem(itemlist, title);
                            break;
                        case 3:
                            order.selectPaymentMethod();
                            Console.WriteLine("--------------");
                            Console.WriteLine(order);
                            orders.Add(order);
                            Console.WriteLine("--------------");

                            break;
                        default:
                            break;
                    }
                } while (x != 4);
            }
        } while (!role.Equals("stop"));
    }
}
