﻿using puskaric.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puskaric.RoleplayingGameLibrary
{
    public class SwordAttack : NormalAttack
    {

        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " swings a sword at " + target.Name + "!");
            base.Attack(attacker, target);
        }

    }
}
