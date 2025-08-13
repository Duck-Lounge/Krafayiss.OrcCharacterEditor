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
        public static Image GetImage(string path)
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", path);
            return Image.FromFile(fullPath);
        }
    }
}
