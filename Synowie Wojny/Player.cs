using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synowie_Wojny
{
    
    internal class Player
    {
        public string Race { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CurrentHP { get; set; }
        public int MaximumHP { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public void Attack(IEnemy enemy)
        {
            // TODO: Implement attack logic
        }

        public void TakeDamage(int dmg)
        {
            CurrentHP -= dmg;
            if (CurrentHP < 0) CurrentHP = 0;
        }


        

    }
}
