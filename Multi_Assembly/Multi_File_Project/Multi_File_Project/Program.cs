using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise;
namespace Multi_File_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer();
            employer.EmployerInfo();
            Employee emproyee = new Employee();
            emproyee.EmployeeInfo();
            Console.ReadLine();
        }
    }
}
