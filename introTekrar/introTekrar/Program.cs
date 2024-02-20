// See https://aka.ms/new-console-template for more information
using introTekrar.Business;
using introTekrar.DataAccess.Concretes;
using introTekrar.Enitites;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string message = "Krediler";
        int term = 12;
        double amount = 10000.6;
        bool isAuthenticaiton = true;

        if (isAuthenticaiton)
        {

            Console.WriteLine("Hoşgeldiniz");
        }
        else
        {
            Console.WriteLine("Lütfen Oturum Açın ");

        }

        Console.WriteLine(message);


        string[] Loans = { "kredi1", "kredi2", "kredi3", "kredi3", "kredi4" };  // bu veri db den gelecek 



        for (int i = 0; i < Loans.Length; i++)
        {

            Console.WriteLine(Loans[i]);
        }


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


        Course[] courses = { course1, course2, course3 };


        for (int i = 0; i < courses.Length; i++)
        {

            Console.WriteLine(courses[i].Name + "  ///  " + courses[i].Price);

        }


        Console.WriteLine("----------------------------------Intarface---------------------------------------"); 
        CourseManager courseManager = new CourseManager(new EFCourseDal());
        List<Course> courses2 = courseManager.GetAll();


        for (int i = 0; i < courses2.Count; i++)
        {
            Console.WriteLine(courses2[i].Name + "  ///  " + courses2[i].Price);
        }



        Console.WriteLine("Kod Bitti....");

        IndividualCustomer customer1 = new IndividualCustomer();
        customer1.Id = 1;
        customer1.NationalIdentity = "12345678922";
        customer1.FirstName = "Aslı";
        customer1.LastName = "Karayiğit";
        customer1.CustomerNumber = "123456";


        IndividualCustomer customer2 = new IndividualCustomer();
        customer2.Id = 2;
        customer2.NationalIdentity = "85245678922";
        customer2.FirstName = "Özgür";
        customer2.LastName = "Atılgan";
        customer2.CustomerNumber = "123457";

        CoorporateCustomer customer3 = new CoorporateCustomer();
        customer3.Id = 3;
        customer3.Name = "Kodlama.io";
        customer3.TaxNumber = "1234567889";
        customer3.CustomerNumber = "12345685";

        CoorporateCustomer customer4 = new CoorporateCustomer();
        customer4.Id = 4;
        customer4.Name = "Ertasart.io";
        customer4.TaxNumber = "8965326541";
        customer4.CustomerNumber = "12348585";

        //value types --> int, bool, double ...
        //reference types --> array, class, interface ... 

        BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

        //polymorphism
        foreach (BaseCustomer customer in customers)
        {
            Console.WriteLine(customer.CustomerNumber);
        }
    }
}