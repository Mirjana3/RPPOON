using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class TextCharacterFactory
    {
        private Dictionary<char, ITextCharacter> characters = new Dictionary<char, ITextCharacter>();
        public ITextCharacter GetCharacter(char character, string font, ConsoleColor color)
        {
            if (!characters.ContainsKey(character))
            {
                characters[character] = new ConcreteTextCharacter(character, font, color);
            }
            return characters[character];
        }

    }
}
