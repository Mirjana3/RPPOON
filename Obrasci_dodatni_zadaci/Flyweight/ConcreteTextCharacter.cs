using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class ConcreteTextCharacter : ITextCharacter
    {
        private char character;
        private string font;
        private ConsoleColor color;
        public ConcreteTextCharacter(char character, string font, ConsoleColor color)
        {
            this.character = character;
            this.font = font;
            this.color = color;
        }
        public void Display(int fontSize)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Character: {character}, Font: {font}, Size: {fontSize}");
            Console.ResetColor();
        }

    }
}
