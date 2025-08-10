using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcCharacterEditor.Models
{
    public interface ITrait<TEnum> where TEnum : Enum
    {
        public TEnum Name { get; set; }
        public int Percent { get; set; }
    }
}
