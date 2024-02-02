using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class Employee : IOrganizationComponent
    {
        private string name;
        private string position;
        public Employee(string name, string position)
        {
            this.name = name;
            this.position = position;
        }
        public void Display()
        {
            Console.WriteLine($"Employee: {name}, Position: {position}");
        }

    }
}
