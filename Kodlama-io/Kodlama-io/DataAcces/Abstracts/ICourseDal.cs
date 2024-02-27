using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAcces.Abstracts
{
    public interface ICourseDal
    {

        void Add (Course course);                 //Create

        List<Course> GetAll ();                   //Read
    }
}
