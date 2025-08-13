using OrcCharacterEditor.Enumerators;
using OrcCharacterEditor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Models
{
    public abstract class CharacterBase
    {
        public Gender Gender { get; set; }
        public int Damage { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public string ImageName => $"{Gender.ToString().ToLower()}-{ClassImageNamePrefix}.png";
        public abstract string ClassImageNamePrefix { get; }
        public CharacterBase(int damage, int dexterity, int intelligence, int charisma, Gender gender)
        {
            Damage = damage;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Charisma = charisma;
            Gender = gender;
        }

        public virtual int CalculateAttackPower()
        {
            return Damage + Dexterity + Intelligence + Charisma;
        }
    }
}
