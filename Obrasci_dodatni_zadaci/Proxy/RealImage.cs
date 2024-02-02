using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class RealImage :IImage
    {
        private string filename;
        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }

        public void Display()
        {
            Console.WriteLine($"Display image: {filename}");
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {filename}");
        }
    }
}
