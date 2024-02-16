using introTekrar.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introTekrar.Business;

public class CourseManager
{
    Course[] courses = new Course[3];  
    public CourseManager()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8 ... VS";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Python";
        course2.Description = "python3,12 ... VS";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 1;
        course3.Name = "JAVA";
        course3.Description = "Java 17 ... VS";
        course3.Price = 20;
        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
     
    public Course[] GetAll() 
    {

        return courses; 

        //Veri Kaynağından Çekilir. 
        Console.WriteLine("Kurslar Listelendi"); 
    }
     }
