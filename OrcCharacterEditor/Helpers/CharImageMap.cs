using OrcCharacterEditor.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Helpers
{
    internal class CharImageMap
    {
        private static readonly Dictionary<(Gender, CharClass), string> _imageMap =
        new()
        {
            { (Gender.Male,   CharClass.Warrior), "male-warrior.png" },
            { (Gender.Male,   CharClass.Archer),  "male-archer.png" },
            { (Gender.Male,   CharClass.Mage),    "male-mage.png" },
            { (Gender.Female, CharClass.Warrior), "female-warrior.png" },
            { (Gender.Female, CharClass.Archer),  "female-archer.png" },
            { (Gender.Female, CharClass.Mage),    "female-mage.png" }
        };

        public static Image GetImage(Gender gender, CharClass classType)
        {
            var fileName = _imageMap[(gender, classType)];
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);
            return Image.FromFile(fullPath);
        }
    }
}
