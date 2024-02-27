using Kodlama_io.DataAcces.Abstracts;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAcces.Concretes; 

public  class CourseDal : ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        courses = new List<Course>
        {
            new Course{Id= 1, CategoryId=1, CourseName="2024 yazılım yetiştirme kampı " , InstructorId =1 , joined = true, UnitPrice= 0},
            new Course{Id= 2, CategoryId=1, CourseName="Senior Yazılım Geliştirici Geliştirme " , InstructorId =1 , joined = true, UnitPrice= 0},
            new Course{Id= 1, CategoryId=1, CourseName="2023 yazılım yetiştirme kampı python  " , InstructorId =2 , joined = false , UnitPrice= 0},
        };   
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetAll()
    {
        return courses; 
    }
}
