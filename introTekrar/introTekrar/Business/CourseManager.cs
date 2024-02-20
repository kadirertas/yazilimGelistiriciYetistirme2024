using introTekrar.DataAccess.Abstracts;
using introTekrar.DataAccess.Concretes;
using introTekrar.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introTekrar.Business;

public class CourseManager
{
    //dependency injection   
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course>  GetAll() 
    {
        // business rules
        return _courseDal.GetAll() ; 

        //Veri Kaynağından Çekilir. 
        Console.WriteLine("Kurslar Listelendi"); 
    }
}
