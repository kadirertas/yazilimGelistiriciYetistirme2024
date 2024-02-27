using Kodlama_io.DataAcces.Abstracts;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAcces.Concretes
{
    public class CategoryDal :ICategoryDal

    {
        List<Category> categories;  


        public CategoryDal() {
        
        
            categories = new List<Category>
            {
                new Category{Id = 1, CategoryName = "Programlama" },
                new Category{Id = 2,CategoryName="Tümü"}
        };
        
     

        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
