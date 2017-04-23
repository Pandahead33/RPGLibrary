using puskaric.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puskaric.RoleplayingGameLibrary
{
    public class NormalAttack : IAttack
    {
        protected Random randomNumbers = new Random();

        public virtual void Attack(ICharacter attacker, ICharacter target)
        {
            int damage = GameConstants.Instance.DamageRange + randomNumbers.Next(GameConstants.Instance.DamageRange);
            target.ReceiveAttack(damage); 

        }
    }
}
