using Intro.DataAccess.Abstracks;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public class EFCourseDal:ICourseDal
{
    List<Course> courses;
    public EFCourseDal()
    {
        Course course = new Course();
        course.Id = 1;
        course.Name = "Javascript";
        course.Description = ".NET 8";
        course.Price = 0;

        Course course1 = new Course();
        course1.Id = 2;
        course1.Name = "SDICVJKDKL";
        course1.Description = " Unreal Engine";
        course1.Price = 56;


        Course course2 = new Course();
        course2.Id = 3;
        course2.Name = "C";
        course2.Description = "oop vs ";
        course2.Price = 86;
        courses = new List<Course> { course, course1, course2, };
    }
    public List<Course> GetAll()
    {
        return courses;
        //sql öğren
        //Burda db işlemleri yapılır 
    }

    public void Add(Course course)
    {

        courses.Add(course);

    }
}
