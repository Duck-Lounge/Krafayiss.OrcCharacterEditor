using OrcCharacterEditor.Logic.Constants;
using OrcCharacterEditor.Logic.Enumerators;
using OrcCharacterEditor.Logic.Helpers;
using OrcCharacterEditor.Logic.Models;

namespace OrcCharacterEditor.Tests
{
    public class CharUpdateTests
    {
        [Theory]
        [InlineData(Gender.Male, 0, 0, 0, 0, 30, 20, 20, 10)]
        [InlineData(Gender.Female, 0, 0, 0, 0, 20, 20, 30, 10)]
        [InlineData(Gender.Female, 50, 50, 50, 50, 60, 35, 95, 10)]
        [InlineData(Gender.Female, 100, 100, 100, 100, 100, 50, 160, 30)]
        [InlineData(Gender.Male, 200, 0, 0, 0, 130, 120, 20, 10)]
        public void ParametersUpdate_ReturnsExpectedValues(
            Gender gender,
            int damage,
            int dexterity,
            int intelligence,
            int charisma,
            double expectedHealth,
            double expectedStamina,
            double expectedLuck,
            double expectedCrit)
        {
            var character = new Mage(damage, dexterity, intelligence, charisma, gender);

            var result = CharUpdate.ParametersUpdate(character);

            Assert.Equal(expectedHealth, result.Health);
            Assert.Equal(expectedStamina, result.Stamina);
            Assert.Equal(expectedLuck, result.Luck);
            Assert.Equal(expectedCrit, result.CritChance);
        }
    }
}