using Kodlama_io.DataAcces.Abstracts;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAcces.Concretes; 

public class InsturctorDal : IInstructorDal

{
    List<Instructor> instructors;

    public InsturctorDal()
    {

        instructors = new List<Instructor>
        {
            new Instructor {Id=1, InstructorName="Engin Demiroğ "}, 
            new Instructor {Id=2,InstructorName= "Halil Enes Kalaycı"}, 
        };    
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);    
    }

    public List<Instructor> GetAll()
    {
        
        return instructors; 
    }
}