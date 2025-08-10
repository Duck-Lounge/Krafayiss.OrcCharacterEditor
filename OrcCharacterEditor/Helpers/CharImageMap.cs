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
        private static readonly Dictionary<(Gender, Class), string> _imageMap =
        new()
        {
            { (Gender.Male,   Class.Warrior), "male-warrior.png" },
            { (Gender.Male,   Class.Archer),  "male-archer.png" },
            { (Gender.Male,   Class.Mage),    "male-mage.png" },
            { (Gender.Female, Class.Warrior), "female-warrior.png" },
            { (Gender.Female, Class.Archer),  "female-archer.png" },
            { (Gender.Female, Class.Mage),    "female-mage.png" }
        };

        public static Image GetImage(Gender gender, Class classType)
        {
            var fileName = _imageMap[(gender, classType)];
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);
            return Image.FromFile(fullPath);
        }
    }
}
