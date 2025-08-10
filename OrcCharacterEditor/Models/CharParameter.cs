using OrcCharacterEditor.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Models
{
    public class CharParameter : ITrait<CharParameterName>
    {
        public CharParameterName Name { get; set; }
        public int Percent { get; set; }
    }
}
