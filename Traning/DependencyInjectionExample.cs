using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    internal class DependencyInjectionExample
    {
    }
    public interface IEmployeeDAL
    {
        List<EmployeeM> SelectAllEmployees();
    }
    public class EmployeeM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<EmployeeM> SelectAllEmployees()
        {
            List<EmployeeM> ListEmployees = new List<EmployeeM>
            {
                //Get the Employees from the Database
                //for now we are hard coded the employees
                new EmployeeM() { ID = 1, Name = "Pranaya", Department = "IT" },
                new EmployeeM() { ID = 2, Name = "Kumar", Department = "HR" },
                new EmployeeM() { ID = 3, Name = "Rout", Department = "Payroll" }
            };
            return ListEmployees;
        }
    }
    public class EmployeeBL
    {
        //public EmployeeDAL employeeDAL;
        //public List<EmployeeM> GetAllEmployees()
        //{
        //    //Creating an Instance of Dependency Class means it is a Tight Coupling
        //    employeeDAL = new EmployeeDAL();
        //    return employeeDAL.SelectAllEmployees();

        //}
        public IEmployeeDAL employeeDAL;
        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }
        public List<EmployeeM> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }
}
