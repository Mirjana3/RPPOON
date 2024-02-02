using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public static class KlijentKod
    {
        public static void Run()
        {
            TextCharacterFactory characterFactory = new TextCharacterFactory();

            ITextCharacter charA = characterFactory.GetCharacter('A', "Arial", ConsoleColor.Red);
            ITextCharacter charB = characterFactory.GetCharacter('B', "Times New Roman", ConsoleColor.Blue);
            ITextCharacter charA2 = characterFactory.GetCharacter('A', "Arial", ConsoleColor.Red); // Ponovno korištenje istog znaka

            charA.Display(12);
            charB.Display(14);
            charA2.Display(16);
        }
    }
}
