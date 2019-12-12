using System;
using System.Collections.Generic;

namespace Game.Adventure
{
    class Game 
    {
        private string _playername;
        private int _difficulty;
        private List<string> _items; 

        public Game(string playername,int difficulty)
        {
            _playername = playername;
            _difficulty = difficulty;
            _items = new List<string> () {"key", "memo", "poison"};
        }
       public void StartGame()
       {
            string _playername;
            int _difficulty;
            List<string> _items = new List<string>(); 
       }
        public string ChangeRoom(string userLocation)
        {
            if (userLocation == "Bedroom")
            {
                return _items[1];
            }
            else if (userLocation == "Bathroom") 
            {
                return "Player had enterd Bathroom.";
            }
            else if (userLocation == "Livingroom") 
            {
                return "Access denied! Hint: Check other room for key.";
            }
            else 
            {
                return "Enter valid choice.";
            }
        }
    }
}