using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category() { }
        public Category(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
        }

        public Category(int categoryID, string categoryName, string description)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
        }
    }
}
