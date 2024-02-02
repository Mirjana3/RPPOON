using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public static class Code
    {
        public static void Run()
        {
            IImage image = new ImageSurrogate("primjer.jpg");

            image.Display();

            image.Display();

        }
    }
}
