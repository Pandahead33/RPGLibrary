using puskaric.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puskaric.RoleplayingGameLibrary
{
    public class BadGradeAttack : NormalAttack
    {

        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " stamps an F on " + target.Name + "'s paper.");
            base.Attack(attacker, target);
        }

    }
}
