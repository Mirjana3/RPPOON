using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class ImageSurrogate : IImage
    {
        private string filename;
        private RealImage image;
        public ImageSurrogate(string filename)
        {
            this.filename = filename;
        }
        public void Display()
        {
            if (image == null)
            {
                image = new RealImage(filename);
            }
            image.Display();
        }

    }
}
