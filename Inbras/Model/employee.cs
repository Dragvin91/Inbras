using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbras.Model
{
  public  class Employee
    {       
        public string LastName { get; set; }
        public Employee(string lastname)
        {
            LastName = lastname;
        }
        public Employee()
        {
        }
    }
}
