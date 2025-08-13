using OrcCharacterEditor.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Models
{
    internal class Archer : CharacterBase
    {
        public Archer(int damage, int dexterity, int intelligence, int charisma, Gender gender)
            : base(damage, dexterity, intelligence, charisma, gender) { }

        public override string ClassImageNamePrefix => nameof(Archer).ToLower();

        public override int CalculateAttackPower()
        {
            return (int)(Intelligence * 1.5 + Charisma * 1.5);
        }
    }
}
