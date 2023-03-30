using Dapper;
using Lab3.Models;

namespace Lab3.Storage
{
    public class RainbowDatabase : Database<RainbowDatabase>
    {
        public Table<Category> Categories { get; set; }
        
        public Table<Employee> Employees { get; set; }
    }
}
