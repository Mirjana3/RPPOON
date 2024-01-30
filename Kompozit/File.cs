using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozit
{
    public class File :FileComponent
    {
        private string Name;

        public File (string name)
        {
            Name = name;
        }

        public override void Display()
        {
            Console.WriteLine($"File: {Name}");
        }
    }
}
