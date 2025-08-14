using OrcCharacterEditor.Logic.Enumerators;
using OrcCharacterEditor.Logic.Helpers;
using OrcCharacterEditor.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Tests
{
    public class CharacterBaseTests
    {
        //Mage
        [Theory]
        [InlineData(Gender.Male, 0, 0, 0, 0, 10)]
        [InlineData(Gender.Female, 50, 50, 50, 50, 160)]
        [InlineData(Gender.Female, 100, 100, 100, 100, 330)]
        [InlineData(Gender.Male, 200, 0, 0, 0, 10)]
        [InlineData(Gender.Male, 0, 50, 50, 0, 160)]
        [InlineData(Gender.Male, 0, 50, 0, 0, 85)]
        [InlineData(Gender.Female, 0, 0, 120, 0, 200)]
        public void Mage_CalculateAttackPower_ReturnsExpectedValues(
            Gender gender,
            int damage,
            int dexterity,
            int intelligence,
            int charisma,
            int expectedAttack)
        {
            var character = new Mage(damage, dexterity, intelligence, charisma, gender);
            var result = character.CalculateAttackPower();

            Assert.Equal(expectedAttack, result);
        }

        //Archer
        [Theory]
        [InlineData(Gender.Male, 0, 0, 0, 0, 10)]
        [InlineData(Gender.Female, 50, 50, 50, 50, 160)]
        [InlineData(Gender.Female, 100, 100, 100, 100, 330)]
        [InlineData(Gender.Male, 200, 0, 0, 0, 10)]
        [InlineData(Gender.Male, 0, 50, 50, 0, 85)]
        [InlineData(Gender.Male, 0, 50, 0, 0, 10)]
        [InlineData(Gender.Female, 0, 0, 120, 0, 200)]
        public void Archer_CalculateAttackPower_ReturnsExpectedValues(
           Gender gender,
           int damage,
           int dexterity,
           int intelligence,
           int charisma,
           int expectedAttack)
        {
            var character = new Archer(damage, dexterity, intelligence, charisma, gender);
            var result = character.CalculateAttackPower();

            Assert.Equal(expectedAttack, result);
        }

        //Warrior
        [Theory]
        [InlineData(Gender.Male, 0, 0, 0, 0, 10)]
        [InlineData(Gender.Female, 50, 50, 50, 50, 160)]
        [InlineData(Gender.Female, 100, 100, 100, 100, 330)]
        [InlineData(Gender.Male, 200, 0, 0, 0, 310)]
        [InlineData(Gender.Male, 0, 50, 50, 0, 85)]
        [InlineData(Gender.Male, 0, 50, 0, 0, 85)]
        [InlineData(Gender.Female, 0, 0, 120, 0, 20)]
        public void Warrior_CalculateAttackPower_ReturnsExpectedValues(
           Gender gender,
           int damage,
           int dexterity,
           int intelligence,
           int charisma,
           int expectedAttack)
        {
            var character = new Warrior(damage, dexterity, intelligence, charisma, gender);
            var result = character.CalculateAttackPower();

            Assert.Equal(expectedAttack, result);
        }
    }
}
