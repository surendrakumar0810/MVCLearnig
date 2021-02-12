using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMVC.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee>  employees = new List<Employee>();
            Employee emp = new Employee
            {
                FirstName = "johnson",
                LastName = " fernandes",
                Salary = 14000
            };
            employees.Add(emp);

            emp = new Employee
            {
                FirstName = "michael",
                LastName = "jackson",
                Salary = 16000
            };
            employees.Add(emp);

            emp = new Employee
            {
                FirstName = "robert",
                LastName = " pattinson",
                Salary = 20000
            };
            employees.Add(emp);

            return employees;
        }
    }
}