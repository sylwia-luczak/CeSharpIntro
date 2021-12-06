using System;
using DinerMax3000.Business;

namespace DinerMax3000Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Menu> menusFromDatabase = Menu.GetAllMenus();

            Order hungryGuestOrder = new Order();

            foreach (Menu currentMenu in menusFromDatabase) 
            {
                foreach (MenuItem currentItem in currentMenu.items) 
                {
                    hungryGuestOrder.items.Add(currentItem);
                }
            
            }

            Console.WriteLine("The total is: " + hungryGuestOrder.Total);

            Console.ReadKey();

        }
    }
}
