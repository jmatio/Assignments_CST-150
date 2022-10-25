using System;
using System.Collections.Generic;

namespace Milestone3
{
    class Program
    {
        static void Main(string[] args)
        {

            //creates new object from inventory manager class
            InventoryManager manager = new InventoryManager();
            int choice;

            //intentional infinite loop to allow user input without termination
            for (;;)
            {

                Console.WriteLine("1: Add item");
                Console.WriteLine("2: Display item");
                Console.WriteLine("3: Remove item");
                Console.WriteLine("4: Search item by name");
                Console.WriteLine("5: Search item by price");
                Console.WriteLine("6: Re-stock item");
                Console.WriteLine("7: Exit");


                Console.WriteLine("Enter choice");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        manager.addItem();
                        break;
                    case 2:
                        manager.displayItem();
                        break;

                    case 3:
                        manager.removeItem();
                        break;
                    case 4:
                        Console.WriteLine("Enter item name to search ");
                        string searchName = Console.ReadLine();
                        manager.searchItemByName(searchName);
                        break;

                    case 5:

                        Console.WriteLine("Enter price to search ");
                        double searchPrice = Convert.ToDouble(Console.ReadLine());
                        manager.searchItemByPrice(searchPrice);
                        break;

                    case 6:
                        Console.WriteLine("Enter item name to edit stock ");
                        string editStock = Console.ReadLine();

                        manager.editItem(editStock);
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;

                }

            }

        }
    }


    class InventoryManager
    {

        //list to hold inventory items
        List<Item> list = new List<Item>();

        //method to add a new item
        public void addItem()
        {
            string name;
            double price;
            int quantity;

            //user will be prompted for each parameter required
            Console.WriteLine("Enter item name ");
            name = Console.ReadLine();

            Console.WriteLine("Enter item price ");
            price = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter item quantity ");
            quantity = Convert.ToInt32(Console.ReadLine());

            //creates new item with user parameters
            Item item = new Item(name, price, quantity);

            //adds new item to list
            list.Add(item);

        }

        //method to display items
        public void displayItem()
        {

            string display = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(display + "\n");

            //will display every item in inventory on its own line
            foreach (Item item in list)
            {

                string newDisplay = String.Format("{0,10}{1,10}{2,10}", item.Name, item.Price, item.Qty);
                Console.WriteLine(newDisplay + "\n");

            }


        }

        //method to remove items
        public void removeItem()
        {

            Console.WriteLine("Enter item name to remove ");
            string name = Console.ReadLine();

            int flag = 0;

            //scans each item by name
            for (int i = 0; i < list.Count; i++)
            {
                //will remove item if name is found
                if (list[i].Name.Equals(name)) 
                {
                    list.RemoveAt(i);
                    Console.WriteLine("Item removed");
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("Item not found");

        }

        //method to search item by name
        public void searchItemByName(string name)
        {

            int flag = 0;

            string display = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(display + "\n");

            //scans each item by name
            foreach (Item item in list)
            {

                //displays item if name is found
                if (item.Name.Equals(name))
                {
                    
                    string newDisplay = String.Format("{0,10}{1,10}{2,10}", item.Name, item.Price, item.Qty);
                    Console.WriteLine(newDisplay + "\n");
                    flag = 1;
                }

            }

            if (flag == 0)
                Console.WriteLine("Item not found");


        }

        //method to search item by price
        public void searchItemByPrice(double price)
        {

            int flag = 0;
            string display = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(display + "\n");

            //scans each item by price
            foreach (Item item in list)
            {

                //displays item if price is found
                if (item.Price == price)
                {
                    
                    string newDisplay = String.Format("{0,10}{1,10}{2,10}", item.Name, item.Price, item.Qty);
                    Console.WriteLine(newDisplay + "\n");
                    flag = 1;
                }

            }

            if (flag == 0)
                Console.WriteLine("Item not found");

        }

        //method for updating or restocking items
        public void editItem(string quantity)
        {


            Console.WriteLine("Enter new stock quantity for this item ");
            string input = Console.ReadLine();

            int num = Convert.ToInt32(input);

            //scans each item in the list
            foreach (Item item in list)
            {

                //changes the quantity if the item is found
                if (item.Name.Equals(quantity))
                {
                    item.Qty = num;
                    Console.WriteLine("quantity updated");
                }

            }

        }

    }


    //simple class to make items
    class Item
    {

        
        string name;
        double price;
        int qty;

        
        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Qty = quantity;

        }

       
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }


    }

}