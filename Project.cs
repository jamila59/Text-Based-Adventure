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
            Console.WriteLine("Welcome to the Escape-Roome game. \nWould the played like to search the Bedroom, Livingroom or Bathroom?");
            string userLocation = Console.ReadLine();
            Console.WriteLine(ourPlayer.ChangeRoom("Bedroom"));

        }

        public static void GetUserName()
        {
            Console.WriteLine("Please enter Player Name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + "!"); 
        }
    }
}