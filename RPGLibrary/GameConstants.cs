using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puskaric.RoleplayingGameLibrary
{
    class GameConstants
    {
        private static GameConstants instance = new GameConstants();

        private const int dodgeDifficulty = 5;
        private const int damageBonus = 5;
        private const int damageRange = 15;
        private const int playerHitpoints = 50;

        private GameConstants()
        {
           
        }

        public static GameConstants Instance
        {
            get { return instance; }
        }
  
        public int DodgeDifficulty
        {
            get { return dodgeDifficulty; }
        }

        public int DamageBonus
        {
            get { return damageBonus; }
        }

        public int DamageRange
        {
            get { return damageRange; }
        }

        public int PlayerHitpoints
        {
            get { return playerHitpoints; }
        }

    }
}
