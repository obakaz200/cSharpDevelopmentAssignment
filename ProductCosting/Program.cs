using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCosting
{
    class Program
    {
        static void Main(string[] args)
        {
            UserIdentity p = new UserIdentity();
            
            p.UserName = "john.gboyega";
            p.FirstName = "John";
            p.LastName = "Gboyega";
            p.Email = "john.gboyega@gmail.com";
            p.Phone = "08085642340";
            
            if(p.CompanyInfo != null)
            {
                p.CompanyInfo.Name = "Chidinma's place";
                p.CompanyInfo.Location = "Lagos";
                p.CompanyInfo.Name = "08085642340";
            }
            
            
            Console.WriteLine(p.Email);
            Console.ReadLine();
        }
    }
}
