using System;
using System.Collections.Generic;

namespace Game.Adventure
{
    class Game 
    {
        public string Playername { get; set; }
        public string Difficulty { get; set; }
        public List<string> Items { get; set; }

        public Game(string playername, string difficulty)
        {
            Playername = playername;
            Difficulty = difficulty;
            Items = new List<string> () {};
        }
    //    public void StartGame()
    //    {
    //         string playername;
    //         int difficulty;
    //         List<string> items = new List<string>(); 
    //    }

    }
}