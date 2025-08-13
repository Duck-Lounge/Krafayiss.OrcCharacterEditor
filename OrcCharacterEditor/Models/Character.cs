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
        public string Name { get; set; }
        public CharacterBase CharacterBase { get; set; }
        public Image Image => CharImageMap.GetImage(CharacterBase.ImageName);
    }
}
