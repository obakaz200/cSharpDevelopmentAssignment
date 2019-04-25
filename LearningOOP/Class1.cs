using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningOOP.HrModule;
namespace LearningOOP.HrModule
{
        public class EmployeePayrollReport
        {
        public enum DocumentType
        {
            Pdf, Excel, Word, Rtf, Txt
        }

        public void GenerateReport(string fileName, DocumentType fileFormat)
            {
                Employee emp = new Employee();
                var salary1 = emp.CalculateSalary();

                Employee emp2 = new Employee();
                var salary2 = emp.CalculateSalary(21);
                string ext = ".txt";

                switch (fileFormat)
                {
                    case DocumentType.Pdf:
                        ext = ".pdf";
                        break;
                    case DocumentType.Excel:
                        ext = ".xls";
                        break;
                    case DocumentType.Rtf:
                        ext = ".rtf";
                        break;
                    case DocumentType.Word:
                        ext = ".doc";
                        break;
                    case DocumentType.Txt:
                       StreamWriter writer = File.CreateText(fileName + ext);
                        writer.WriteLine($"Salary for Employee 002 is : NGN {salary2:N}");
                        writer.WriteLine($"Salary for Employee 001 is : NGN {salary1:N}");
                        writer.Flush();
                        writer.Close();
                        break;


                }
            }
        }
    }