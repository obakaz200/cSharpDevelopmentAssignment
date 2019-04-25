using HumanResourceManager.HrModule;
using LearningOOP.HrModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            EmployeePayrollReport rpt = new EmployeePayrollReport();
            rpt.GenerateReport(doc + "\\2019_April_Salary_report", EmployeePayrollReport.DocumentType.Txt);
            Console.ReadLine();



            Dog zara = new Dog();
            zara.Age = 4;
            zara.Name = "Zara";
            zara.Bark();
            Console.WriteLine(zara);
            Console.ReadLine();

            Person p = new Person();
            Person p2 = new Person();
            p.SetFirstName("James O.");
            p.GetFirstName();
            p.FirstName = "Alfred";
            string nameUpper = p.FirstName.ToUpper();
            Console.WriteLine(nameUpper);
            p.LastName = "";
            Console.ReadLine();
        }
    }
}
