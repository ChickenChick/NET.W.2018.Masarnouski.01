using System;
using System.Reflection;

[assembly: AssemblyKeyFile("KeysPair.snk")]

namespace Enterprise
{
    public class Employer
    {
        public void EmployerInfo()
        {
            Console.WriteLine("Информация о нанимателе: ");
        }
    }
}