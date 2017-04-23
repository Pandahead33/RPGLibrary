using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puskaric.RoleplayingGameLibrary
{
    public interface IAttack
    {
        //Methods
        void Attack(ICharacter attacker, ICharacter targer);
    }
}
