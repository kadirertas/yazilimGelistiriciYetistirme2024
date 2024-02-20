using introTekrar.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introTekrar.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll(); 
    void Add (Course course);   

}
