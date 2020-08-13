using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbras.Model
{
    public class Department
    {
        public string NameDepartment { get; set; }
        public List<Employee> Employee { get; set; }
        public Department(string name_department, List<Employee> employee)
        {
            NameDepartment = name_department;
            Employee = employee;
        }
        public Department()
        {

        }
    }

}
