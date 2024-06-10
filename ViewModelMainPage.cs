using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_IssueReleaseModeNotRendering
{
    public class ViewModelMainPage
    {
        public ObservableCollection<ViewModelEmployee> EmployeeList
        {
            get; set;
        }

        public ViewModelMainPage()
        {
            EmployeeList = new ObservableCollection<ViewModelEmployee>();
            EmployeeList.Add(new ViewModelEmployee() { EmployeeName = "Test1", EmployeeAge = 30, EmployeeSex = "Male" });
            EmployeeList.Add(new ViewModelEmployee() { EmployeeName = "Test2", EmployeeAge = 31, EmployeeSex = "Female" });
            EmployeeList.Add(new ViewModelEmployee() { EmployeeName = "Test3", EmployeeAge = 32, EmployeeSex = "Female" });
            EmployeeList.Add(new ViewModelEmployee() { EmployeeName = "Test4", EmployeeAge = 33, EmployeeSex = "Male" });
        }
    }
}
