using puskaric.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puskaric.RoleplayingGameLibrary
{
    public class FireAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " shoots fire at " + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
