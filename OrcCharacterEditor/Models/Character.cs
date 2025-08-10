using OrcCharacterEditor.Enumerators;
using OrcCharacterEditor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Models
{
    public class Character
    {
        public Gender Gender { get; set; }
        public Class Class { get; set; }
        public Image Image => CharImageMap.GetImage(Gender, Class);
        public int Damage { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Сharisma { get; set; }
    }
}
