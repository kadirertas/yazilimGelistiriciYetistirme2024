using introTekrar.DataAccess.Abstracts;
using introTekrar.Enitites;

namespace introTekrar.DataAccess.Concretes;

public class EFCourseDal:ICourseDal
{
    List<Course> courses;
    public EFCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JAVASCRİPT";
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
        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {

        // burada Db işlemleri yapılır 
        // Db Öğren 
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
