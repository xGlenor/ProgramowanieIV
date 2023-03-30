using Lab3.Models;
using Lab3.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public IEnumerable<Category> All()
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            List<Category> categories = db.Categories.All().ToList();
            return categories;
        }

        public Category Get(int id)
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            return db.Categories.Get(id);
        }

        public void Insert(Category t)
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            db.Categories.Insert(new { CategoryName = t.CategoryName, Description = t.Description});
        }

        public void Update(Category t)
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            db.Execute($"UPDATE {db.Categories.TableName} SET " +
                $"CategoryName = '{t.CategoryName}', " +
                $"Description = '{t.Description}' " +
                $"WHERE CategoryID = '{t.CategoryID}'");
        }

        public void Delete(int id)
        {
            var db = Database.GetDatabase().GetRainbowDatabase();
            db.Execute($"DELETE FROM {db.Categories.TableName} WHERE CategoryID = '{id}'");
        }

    }
}
