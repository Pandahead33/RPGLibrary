using puskaric.RoleplayingGameLibrary;
using System;
using System.Collections.Generic;

namespace puskaric.RPGTester
{
    /*
     * Author: Lucas Puskaric
     * CSE 4523 
     * Create an RPG Library 
     */
    class Program
    {

        static void Main(string[] args)
        {
            //Initalize variables
            IList<ICharacter> playerParty = new List<ICharacter>();
            IList<ICharacter> enemyParty = new List<ICharacter>();
            string playerPartyName = "Heroes";
            string enemyPartyName = "Villains";

            //Create player characters
            ICharacter player1 = new Mage("Harry Potter", 41);
            ICharacter player2 = new Warrior("Carl Sagan", 110);
            ICharacter player3 = new Archer("Robin Hood", 62);
            ICharacter player4 = new ComputerWizard("Elon Musk", 75);

            //Create enemy characters
            ICharacter enemy1 = new Mage("Voldemort", 90);
            ICharacter enemy2 = new Warrior("Neil deGrasse Tyson", 41);
            ICharacter enemy3 = new Archer("Sheriff of Nottingham", 41);
            ICharacter enemy4 = new ComputerWizard("Robert Morris", 80);

            //Add players to party
            playerParty.Add(player1);
            playerParty.Add(player2);
            playerParty.Add(player3);
            playerParty.Add(player4);

            //Add enemys to party
            enemyParty.Add(enemy1);
            enemyParty.Add(enemy2);
            enemyParty.Add(enemy3);
            enemyParty.Add(enemy4);

            //Initalize combat 
            Combat battle = new Combat(playerParty, enemyParty, playerPartyName, enemyPartyName);

            //Commence combat
            battle.AutoBattle();

        }
    }
}