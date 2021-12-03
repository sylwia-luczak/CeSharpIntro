using System;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with butter", 25.50);
            summerMenu.AddMenuItem("Taco", "Good taco", 10);
            summerMenu.HospitalDirections = "Right around the corner od 5th street. Ask for Dr.House";

            //MenuItem salmon = new MenuItem();
            //salmon.Title = "Salmon";
            //salmon.Description = "Fresh Norwegian Salmon with butter";
            //salmon.Price = 25.50;
            //summerMenu.items.Add(salmon);

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "DO not drink and code.";
            outsideDrinks.AddMenuItem("Virgin Cuba Libre", "A classic drink", 10);
            outsideDrinks.AddMenuItem("Screwdriver", "Vodka with orange juice", 15);

            Order hungryGuestOrder = new Order();

            for (int x = 0; x <= summerMenu.items.Count-1; x++) 
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach(MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }

            Console.WriteLine("The total is: " + hungryGuestOrder.Total);

            try
            {
                outsideDrinks.AddMenuItem("Himkok", "Good drink", 0);

            }
            catch (Exception thrownException) 
            {
                Console.WriteLine(thrownException.Message);
            }

            Console.ReadKey();

        }
    }
}
