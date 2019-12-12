using System;
using System.Collections.Generic;

namespace Game.Adventure
{
    class Project 
    {
        public static Game ourPlayer = new Game("Jim", 1);
         static void Main() // might not need "public"
        {
            GetUserName();
            Console.WriteLine(ChangeRoom());

        }
        public static void GetUserName()
        {
            Console.WriteLine("Please enter Player Name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + "!"); 
        }
        public static string ChangeRoom()
        {
            Console.WriteLine("Welcome to the Escape-Roome game. \nWould the played like to search the Bedroom, Livingroom or Bathroom?");
            string userLocation = Console.ReadLine();

            if (userLocation == "Bedroom")
            {
                return ourPlayer._items[1];
            }
            else if (userLocation == "Bathroom") 
            {
                return "Player had enterd Bathroom.";
            }
            else if (userLocation == "Livingroom") 
            {
                Console.WriteLine("Access denied! Hint: Check other room for key.");
                return ChangeRoom();
            }
            else 
            {
                return "Enter valid choice.";
            }
        }
    }
}