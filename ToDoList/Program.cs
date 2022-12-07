using System;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Welcome();
    }

    public static void Add()
    {
      Console.WriteLine("Please enter the description for the new item.");
      string description = Console.ReadLine();
      Item item = new Item(description);
      Console.WriteLine("'{0}' has been added to your list", description);
      Welcome();
    }

    public static void View()
    {
      int ctr = 1;
      foreach (Item item in Item.GetAll())
      {
        Console.WriteLine("{0}. {1}", ctr, item.Description);
        ctr++;
      }
      Welcome();
    }

    public static void Welcome()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string ans = Console.ReadLine().Trim().ToLower();

       if (ans == "add")
      {
        Add();
      }
      else if (ans == "view")
      {
        View();
      }
    }
  }

}
