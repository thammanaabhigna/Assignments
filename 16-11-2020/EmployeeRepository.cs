using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace Myapp.Db.DBoperations
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmployeeModel model)
        {
            using (var context = new EmployeeDBEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code

                };
                if (model.Address != null)
                {
                    emp.Address = new Address()
                    {
                        Details = model.Address.Details,
                        Country = model.Address.Country,
                        State = model.Address.State

                    };
                }
                context.Employee.Add(emp);
                context.SaveChanges();
                return emp.ID;
            }
        }
        public List<EmployeeModel> GetAllEmployees()
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = context.Employee.Select(x => new EmployeeModel()
                {
                    ID = x.ID,
                    AddressID = x.AddressID,
                    Code = x.Code,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = new AddressModel()
                    {
                        ID = x.Address.ID,
                        Details = x.Address.Details,
                        Country = x.Address.Country,
                        State = x.Address.State
                    }
                }).ToList();
                return result;

            }
        }
        public List<EmployeeModel> GetEmployee(int id)
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = context.Employee
                    .Where(x => x.ID == id)
                    .Select(x => new EmployeeModel()
                    {
                        ID = x.ID,
                        AddressID = x.AddressID,
                        Code = x.Code,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address = new AddressModel()
                        {
                            ID = x.Address.ID,
                            Details = x.Address.Details,
                            Country = x.Address.Country,
                            State = x.Address.State
                        }
                    }).FirstOrDefault();
                return result;
            }
        }

    }
}
