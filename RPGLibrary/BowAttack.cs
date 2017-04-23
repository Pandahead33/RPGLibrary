using puskaric.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puskaric.RoleplayingGameLibrary
{
    public class BowAttack : NormalAttack
    {

        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " slings an arrow in the general direction of " + target.Name + ". They take it to the knee!");
            base.Attack(attacker, target);
        }

    }
}
