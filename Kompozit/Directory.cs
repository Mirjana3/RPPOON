using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozit
{
    public class Directory : FileComponent
    {
        private string Name;
        private List<FileComponent> Files;

        public Directory(string name)
        {
            Name = name;
            Files = new List<FileComponent>();
        }

        public void AddComponent(FileComponent component)
        {
            Files.Add(component);
        }

        public void RemoveComponent(FileComponent component)
        {
            Files.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine($"Directory: {Name}");
            foreach (var child in Files)
            {
                child.Display();
            }
        }
    }
}
