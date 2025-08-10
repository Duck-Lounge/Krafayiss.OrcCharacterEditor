using OrcCharacterEditor.Constants;
using OrcCharacterEditor.Enumerators;
using OrcCharacterEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Helpers
{
    internal class FormUpdate
    {
        public static CharParameters ParametersUpdate(Character character)
        {
            //Создание копий характеристик персонажа из входных параметров для вычислений
            double damage = character.Damage;
            double dexterity = character.Dexterity;
            double intelligence = character.Intelligence;
            double charisma = character.Сharisma;

            // Инициализация параметров дефолтными значениями
            double charHealth = CharTraitsConst.health;
            double charStamina = CharTraitsConst.stamina;
            double charLuck = CharTraitsConst.luck;
            double charCrit = CharTraitsConst.crit;


            // у Ж +10 к харизме, у М - к здоровью
            if (character.Gender == Gender.Female) charLuck += 10;
            else charHealth += 10;

            // Сила
            charHealth += (damage / 10) * 2;
            charStamina += (damage / 10) * 2;

            // Ловкость
            charHealth += (dexterity / 10) * 2;
            charLuck += (dexterity / 10) * 1;

            // Интеллект
            charLuck += (intelligence / 10) * 2;
            charStamina -= (intelligence / 10) * 1;
            if (charStamina < 1) charStamina = 1;

            // Харизма
            charLuck += (charisma / 10) * 2;
            charHealth -= (charisma / 10) * 1;
            if (charHealth < 1) charHealth = 1;

            // Критический удар
            if (dexterity >= 100) charCrit += 10;
            if (intelligence >= 100) charCrit += 10;

            CharParameters parameters = new()
            {
                Health = charHealth,
                Stamina = charStamina,
                Luck = charLuck,
                CritChance = charCrit
            };

            return parameters;
        }
    }
}
