﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    internal class DependencyInjectionExample
    {
    }
    // Внедрение зависимостей в конструктор
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
        // пример без внедрения зависимостей
        //public EmployeeDAL employeeDAL;
        //public List<EmployeeM> GetAllEmployees()
        //{
        //    //Creating an Instance of Dependency Class means it is a Tight Coupling
        //    employeeDAL = new EmployeeDAL();
        //    return employeeDAL.SelectAllEmployees();

        //}

        //public IEmployeeDAL employeeDAL;
        //public EmployeeBL(IEmployeeDAL employeeDAL)
        //{
        //    //пример с внедрением зависимостей в конструктор
        //    this.employeeDAL = employeeDAL;
        //}
        //public IEmployeeDAL EmployeeDataObject
        //{
        //    // пример с внедрением зависимостей в свойство
        //    set
        //    {
        //        this.employeeDAL = value;
        //    }
        //}
        public List<EmployeeM> GetAllEmployees(IEmployeeDAL employeeDAL)
        {
            // пример с внедрением зависимостей через метод
            return employeeDAL.SelectAllEmployees();
        }    
    }
    interface ID
    {
        int Sum(int x, int y, int z);
        string Output();
    }
    class Ddd : ID
    {
        public int Sum(int x, int y, int z) => x + y + z;
        public string Output() => "Output";
    }

    class Eee
    {
        ID Id;
        public Eee(ID id)
        {
            Id = id;
        }
        //public ID E
        //{
        //    set 
        //    {
        //        this.Id = value;
        //    }
        //}
        //Ddd ddd;
        public int GetSum()
        {
            //ddd = new Ddd();
            Console.WriteLine("1 " + Id.Output());
            return Id.Sum(4, 5, 6);
        }
    }
}
