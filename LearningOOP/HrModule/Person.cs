using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManager.HrModule
{
    public class Person
    {
        float height;
        string firstName;
        
        int age;

     public void SetFirstName(string newName)
        {
            this.firstName = newName;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                 firstName = value;
            }
        }
        public float Height
        {
            get
            {
                return height; // Read only
            }
        }
        public string LastName { get; set; }
    }
}
