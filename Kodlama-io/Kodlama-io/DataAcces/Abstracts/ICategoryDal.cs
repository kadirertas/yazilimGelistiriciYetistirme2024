using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAcces.Abstracts
{
    public interface ICategoryDal
    {


        void Add(Category category);                 //Create
         List<Category> GetCategories();             //Read 
    }
}
