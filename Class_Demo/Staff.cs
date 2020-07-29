using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public class Staff<T>
    {
        //===== PROPERTIES
        public List<Employee<T>> Employees = new List<Employee<T>>();

        //===== GET EMPLOYEE - filter employees that match input criteria, return list of employee objects, option to execute using lambda expression
        public List<Employee<T>> GetEmployees(string fName = "", bool lamb = true)
        {
            List<Employee<T>> filtered = new List<Employee<T>>();
            //=== FIRST NAME - filter if first name matches the input 
            if (lamb)
            {
                filtered = Employees.Where(e => (e.FirstName == fName && fName != "") || fName == "").ToList();
            }
            else
            {
                foreach (Employee<T> e in Employees)
                {
                    if ((fName != "" && e.FirstName == fName) || fName == "") { filtered.Add(e); }
                }                
            }
            return filtered;
        }


        //===== OPERATOR METHODS (+ , -): Add/remove employee from staff
        public static Staff<T> operator +(Staff<T> staff, Employee<T> employee)
        {
            staff.Employees.Add(employee);
            return staff;
        }
        public static Staff<T> operator -(Staff<T> staff, Employee<T> employee)
        {
            staff.Employees.Remove(employee);
            return staff;
        }

        //===== OPERATOR METHODS (> , < , >= , <=, ==, !=): Create filtered list of employees used Id comparitor
        public static List<Employee<T>> operator >(Staff<T> staff, int id)
        {
            List<Employee<T>> filtered = staff.Employees.Where(e => e.Id > id).ToList();
            return filtered;
        }
        public static List<Employee<T>> operator <(Staff<T> staff, int id)
        {
            List<Employee<T>> filtered = staff.Employees.Where(e => e.Id < id).ToList();
            return filtered;
        }
        public static List<Employee<T>> operator <=(Staff<T> staff, int id)
        {
            List<Employee<T>> filtered = staff.Employees.Where(e => e.Id <= id).ToList();
            return filtered;
        }
        public static List<Employee<T>> operator >=(Staff<T> staff, int id)
        {
            List<Employee<T>> filtered = staff.Employees.Where(e => e.Id >= id).ToList();
            return filtered;
        }
        public static List<Employee<T>> operator ==(Staff<T> staff, int id)
        {
            List<Employee<T>> filtered = staff.Employees.Where(e => e.Id == id).ToList();
            return filtered;
        }
        public static List<Employee<T>> operator !=(Staff<T> staff, int id)
        {
            List<Employee<T>> filtered = staff.Employees.Where(e => e.Id != id).ToList();
            return filtered;
        }
    }
}
