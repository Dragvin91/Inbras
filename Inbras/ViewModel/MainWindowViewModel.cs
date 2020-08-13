using Inbras.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbras.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Department> Department { get; set; }
        public Department Select_Department { get; set; }
        public MainWindowViewModel()
        {
            Department = new ObservableCollection<Department>();
            Department=GenerateDepartments();
        }
      public  ObservableCollection<Department> GenerateDepartments()
        {var tempDepartments= new ObservableCollection<Department>();
            var firstDepartment = new Department();
            firstDepartment.NameDepartment = "Охрана";           
            var secondEmployees = new List<Employee>();
            secondEmployees.Add(new Employee("Петров"));
            secondEmployees.Add(new Employee("Иванов"));
            secondEmployees.Add(new Employee("Сидоров"));
            var secondDepartment = new Department("IT-отдел",secondEmployees);
            var thirdEmployees = new List<Employee>();
            thirdEmployees.Add(new Employee("Данилов"));
            thirdEmployees.Add(new Employee("Семенов"));
            thirdEmployees.Add(new Employee("Васильев"));
            var thirdDepartment = new Department("Уборка", thirdEmployees);
            tempDepartments.Add(firstDepartment);
            tempDepartments.Add(secondDepartment);
            tempDepartments.Add(thirdDepartment);
            return tempDepartments;
        }
    }
}
