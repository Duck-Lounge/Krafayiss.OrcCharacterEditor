using OrcCharacterEditor.Enumerators;
using OrcCharacterEditor.Helpers;
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
            CharParameters parameters = CharUpdate.ParametersUpdate(this);
            return (int)(Damage * 1.5 + Dexterity * 1.5 + parameters.CritChance);
        }
    }
}
