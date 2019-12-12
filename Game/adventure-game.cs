using System;
using System.Collections.Generic;

namespace Game.Adventure
{
    class Game 
    {
        public string _playername { get; set; }
        public int _difficulty { get; set; }
        public List<string> _items { get; set; }

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
    }
}