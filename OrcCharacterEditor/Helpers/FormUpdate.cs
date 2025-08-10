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
        public static void ParametersUpdate(Character character)
        {
            // Пересчёт параметров
            double health = 100;
            double stamina = 100;
            double luck = 0;
            double crit = 5;

            // Пол
            if (gender == Gender.Female) luck += 10;
            else health += 10;

            // Сила
            health += (damage / 5) * 2;
            stamina += (damage / 5) * 2;

            // Ловкость
            health += (dexterity / 5) * 2;
            luck += (dexterity / 5) * 1;

            // Интеллект
            luck += (intelligence / 5) * 2;
            stamina -= (intelligence / 5) * 1;
            if (stamina < 1) stamina = 1;

            // Харизма
            luck += (charisma / 5) * 2;
            health -= (charisma / 5) * 1;
            if (health < 1) health = 1;

            // Критический удар
            if (dexterity >= 50) crit += 5;
            if (intelligence >= 50) crit += 5;

        }
    }
}
