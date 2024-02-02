using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public static class Kod
    {
        public static void Run()
        {
            Employee employee1 = new Employee("Maja", "Developer");
            Employee employee2 = new Employee("Ena", "Developer");

            Department developmentDepartment = new Department("Developer Department");
            developmentDepartment.Add(employee1);
            developmentDepartment.Add(employee2);

            Department designDepartment = new Department("Design Department");
            designDepartment.Add(new Employee("Filip", "Graphic Designer"));

            Department mainDepartment = new Department("Main Department");
            mainDepartment.Add(developmentDepartment);
            mainDepartment.Add(designDepartment);

            mainDepartment.Display();
        }
    }
}
