using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Hatori";
            CurrentPlayer.CharacterClass = "Samurai";
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.Gold = 1;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
        }
    }
}
