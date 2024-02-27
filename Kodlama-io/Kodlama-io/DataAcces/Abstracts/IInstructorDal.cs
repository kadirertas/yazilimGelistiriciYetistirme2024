using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAcces.Abstracts
{
    public interface IInstructorDal
    {

        void Add(Instructor instructor);            //Create
        
        List<Instructor> GetAll();                 //Read
    }
}
