using Dapper;
using Lab3.Models;
using Lab3.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public IEnumerable<Employee> All()
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            List<Employee> employees = db.Employees.All().ToList();
            return employees;
        }

        public Employee Get(int id)
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            return db.Employees.Get(id);
        }

        public void Insert(Employee t)
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            db.Employees.Insert(new {FirstName = t.FirstName, LastName = t.LastName, Address = t.Address});
        }

        public void Update(Employee t)
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            db.Execute($"UPDATE {db.Employees.TableName} SET " +
                $"FirstName = '{t.FirstName}', " +
                $"LastName = '{t.LastName}', " +
                $"Address = '{t.Address}' " +
                $"WHERE EmployeeID = '{t.EmployeeID}'");
        }

        public void Delete(int id)
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            db.Execute($"DELETE FROM {db.Employees.TableName} WHERE EmployeeID = '{id}'");
        }

    }
}
