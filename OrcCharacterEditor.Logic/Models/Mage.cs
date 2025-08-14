using OrcCharacterEditor.Logic.Enumerators;
using OrcCharacterEditor.Logic.Helpers;

namespace OrcCharacterEditor.Logic.Models;

public class Mage : CharacterBase
{
    public Mage(int damage, int dexterity, int intelligence, int charisma, Gender gender)
        : base(damage, dexterity, intelligence, charisma, gender) { }

    public override string ClassImageNamePrefix => nameof(Mage).ToLower();
    public override int CalculateAttackPower()
    {
        CharParameters parameters = CharUpdate.ParametersUpdate(this);
        return (int)(Dexterity * 1.5 + Intelligence * 1.5 + parameters.CritChance);
    }
}
