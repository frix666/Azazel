﻿using System;
using System.Collections.Generic;

class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static List<Item> order = new List<Item>();

    static void Main()
    {
        Console.WriteLine("Ordering Application");

        int choice;
        do
        {
            Console.WriteLine("1. Add Item to Order");
            Console.WriteLine("2. View Order Summary");
            Console.WriteLine("3. Place Order");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddItem();
                    break;
                case 2:
                    ViewOrderSummary();
                    break;
                case 3:
                    PlaceOrder();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

        } while (choice != 4);
    }

    static void AddItem()
    {
        Item item = new Item();
        Console.Write("Enter item name: ");
        item.Name = Console.ReadLine();
        Console.Write("Enter item price: ");
        double price;
        if (!double.TryParse(Console.ReadLine(), out price))
        {
            Console.WriteLine("Invalid price. Please enter a valid number.");
            return;
        }
        item.Price = price;
        order.Add(item);
        Console.WriteLine("Item added to order.");
    }

    static void ViewOrderSummary()
    {
        if (order.Count == 0)
        {
            Console.WriteLine("Order is empty.");
            return;
        }
        Console.WriteLine("Order Summary:");
        foreach (var item in order)
        {
            Console.WriteLine($"- {item.Name}: ${item.Price}");
        }
    }

    static void PlaceOrder()
    {
        if (order.Count == 0)
        {
            Console.WriteLine("Order is empty. Cannot place empty order.");
            return;
        }

        double totalPrice = 0;
        foreach (var item in order)
        {
            totalPrice += item.Price;
        }

        Console.WriteLine($"Total Price of Order: ${totalPrice}");
        order.Clear();
        Console.WriteLine("Order placed. Thank you!");
    }
}
