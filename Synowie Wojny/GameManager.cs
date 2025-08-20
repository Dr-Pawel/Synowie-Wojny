using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synowie_Wojny
{
    public class GameManager
    {
        public Player CreatePlayer(string race, string name, int age)
        {
            return new Player
            {
                Race = race,
                Name = name,
                Age = age,
                MaximumHP = 100,
                CurrentHP = 100
            };
        }
    }
}