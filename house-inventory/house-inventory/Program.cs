using System;

namespace house_inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            House[] houseInventory = new House[]
            {
                new House {address = "This my house", price = 1000000, size = 10000 },
                new House {address = "This is your house", price = 50000, size = 500 },
                new House {address = "This is neither of our houses", price = 150000, size = 1600 }
            };

            Console.WriteLine("Press Enter to see all available house inventory");
            Console.ReadLine();
            House.DisplayInventory(houseInventory);
        }
    }

    class House
    {
        public string address { get; set; }
        public int size { get; set; }
        public int price { get; set; }

        public static void DisplayInventory(House[] houseInventory)
        {
            foreach (var house in houseInventory)
            {
                Console.WriteLine($"Address: {house.address} / Size: {house.size} / Price: {house.price}");
            }
        }
    }
}
