using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public Employee(string firstName, string lastName, string identityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IdentityNumber = identityNumber;
        }
        public override string ToString()
        {
            return String.Format("{0} -- {1} -- {2}",FirstName , LastName, IdentityNumber); 
        }
        public override bool Equals(object obj)
        {
            var item = obj as Employee;

            if (item == null)
            {
                return false;
            }

            return this.IdentityNumber.Equals(item.IdentityNumber);
        }

        public override int GetHashCode()
        {
            return this.IdentityNumber.GetHashCode();
        }
    }
}
