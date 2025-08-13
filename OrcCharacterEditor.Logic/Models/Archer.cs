using OrcCharacterEditor.Logic.Enumerators;
using OrcCharacterEditor.Logic.Helpers;

namespace OrcCharacterEditor.Logic.Models;

public class Archer : CharacterBase
{
    public Archer (int damage, int dexterity, int intelligence, int charisma, Gender gender)
        : base(damage, dexterity, intelligence, charisma, gender) { }

    public override string ClassImageNamePrefix => nameof(Archer).ToLower();

    public override int CalculateAttackPower()
    {
        CharParameters parameters = CharUpdate.ParametersUpdate(this);
        return (int)(Intelligence * 1.5 + Charisma * 1.5 + parameters.CritChance);
    }
}
