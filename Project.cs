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

        }
        public static void GetUserName()
        {
            Console.WriteLine("Welcome to the Escape-Roome game. \n Please enter Player Name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Select difficulty: Easy or Hard");
            Console.WriteLine("Hello " + userName + "!");
            ChangeRoom(userName);
        }
        public static void ChangeRoom(string userName)
        {
            Console.WriteLine("Would the played like to search the Bedroom, Livingroom or Bathroom?");
            string userLocation = Console.ReadLine();

            if (userLocation == "Bedroom")
            {
                Console.WriteLine(userName + "has entered the Bedroom");
                PocketItem(userLocation, userName);
            }
            else if (userLocation == "Bathroom") 
            {
                Console.WriteLine(userName +"has enterd the Bathroom.");
                PocketItem(userLocation,userName);
            }
            else if (userLocation == "Livingroom") 
            {
                if(!(ourPlayer.Items[0] == "key" || ourPlayer.Items[1] == "key") && (ourPlayer.Items[0] == "POOPY" || ourPlayer.Items[1] == "POOPY"))
                {
                Console.WriteLine("Access denied! Hint: Check other room for key.");
                ChangeRoom(userName);
                }
                else
                {
                    Console.WriteLine(userName + " have entered the living room and escaped!");
                }
            }
            else 
            {
                Console.WriteLine("Enter valid choice.");
                ChangeRoom(userName);
            }
        }

        public static void PocketItem(string userLocation, string userName)
        {
            Console.WriteLine("You are now in the " + userLocation + ".");
            if (userLocation == "Bedroom")  
            {
                Console.WriteLine("Would You like to check under the bed for clues?");
                string response1 = Console.ReadLine();

                if (response1 == "Yes")
                {
                    Console.WriteLine("You have found a key!");
                    ourPlayer.Items.Add("key");
                    ChangeRoom(userName);
                }
                else 
                {
                    Console.WriteLine("Okay... try again");
                    PocketItem(userLocation,userName);

                }
            }
            if (userLocation == "Bathroom") 
            {
                Console.WriteLine("Would you like to search the toilet for clues?");
                string response2 = Console.ReadLine();
                if(response2 == "Yes")
                {
                    Console.WriteLine("You have rescued a new friend by the name POOPY");
                    ourPlayer.Items.Add("POOPY");
                    ChangeRoom(userName);
                }
                else 
                {
                    Console.WriteLine("Okay... try again");
                    PocketItem(userLocation, userName);
                }
            } 
        }
    }
}