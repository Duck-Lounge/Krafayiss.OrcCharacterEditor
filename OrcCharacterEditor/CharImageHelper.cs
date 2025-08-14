using OrcCharacterEditor.Logic.Models;

namespace OrcCharacterEditor.Logic.Helpers;

public class CharImageHelper
{
    public static Image GetImage(CharacterBase character)
    {
        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", character.ImageName);
        if (File.Exists(fullPath))
            {
                return Image.FromFile(fullPath);
            }
        return null;
    }
}
