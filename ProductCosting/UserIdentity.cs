using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCosting
{
    public class UserIdentity
    {
        
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public UserCompanyInfo CompanyInfo { get; internal set; }

        public UserIdentity()
        {
            // Instantiate  Company info
            CompanyInfo = new UserCompanyInfo();
        }

        public UserIdentity(string id, string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = id ?? Guid.NewGuid().ToString();
        }
        public string FullName => $"{FirstName ?? "" } {LastName ?? ""}";
    }
    public class UserCompanyInfo
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string phoneNo { get; set; }

        

    }
    
}
