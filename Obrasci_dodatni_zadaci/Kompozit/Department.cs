using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class Department : IOrganizationComponent
    {
        private string name;
        private List<IOrganizationComponent> members = new List<IOrganizationComponent>();
        public Department(string name)
        {
            this.name = name;
        }
        public void Add(IOrganizationComponent component)
        {
            members.Add(component);
        }

        public void Remove(IOrganizationComponent component)
        {
            members.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine($"Department: {name}");
            foreach (var member in members)
            {
                member.Display();
            }
        }

    }
}
