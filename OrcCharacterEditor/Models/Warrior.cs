using OrcCharacterEditor.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Models
{
    internal class Warrior : CharacterBase
    {
        public Warrior(int damage, int dexterity, int intelligence, int charisma, Gender gender)
            : base(damage, dexterity, intelligence, charisma, gender) { }

        public override string ClassImageNamePrefix => nameof(Warrior).ToLower();

        public override int CalculateAttackPower()
        {
            return (int)(Damage * 1.5 + Dexterity * 1.5);
        }
    }
}
