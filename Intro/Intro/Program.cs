// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");




string message = "Krediler";
int term =  4;
double amount = 40000;
double yeniFiyat=0; 
bool isAuthenticated = false; 

if ( isAuthenticated) 
{

    Console.WriteLine("Hoşgeldin Kadir");


    if (amount < 50000)
    {
        if (term > 6)
        {
            Console.WriteLine("İstediniz Krerdi mitarı bu vadeye uygun değil");

        }
        else
        {
            yeniFiyat = amount + amount / 1000;

            Console.WriteLine("Toplam Ödeyeceğiniz Kredi Miktarı: " + yeniFiyat);

        }



    }

    else
    {
        if (term > 6 && term <= 15)
        {

            yeniFiyat = amount + amount / 1000;

            Console.WriteLine("Toplam Ödeyeceğiniz Kredi Miktarı:  " + yeniFiyat);

        }
        else if (term > 15)
        {

            Console.WriteLine("Vade ayınız Fazla Olduğundan kredi faiz oranınız artmıştır");
            yeniFiyat = amount + amount / 750;

            Console.WriteLine("Toplam Ödeyeceğiniz Kredi Miktarı: " + yeniFiyat);

        }



    }


}
else 
{

    Console.WriteLine("Lütfen Oturumunu Aç"); 

}

string[] loans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4", "kredi 5", "kredi 6" };


for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);     
}


Course course = new Course();
course.Id = 1;
course.Name = "C#";
course.Description = ".NET 8";
course.Price = 0;

Course course1 = new Course();
course1.Id = 2;
course1.Name = "C++";
course1.Description = " Unreal Engine";
course1.Price = 56;


Course course2 = new Course();
course2.Id = 3;
course2.Name = "C";
course2.Description = "oop vs ";
course2.Price = 86;


Course[] courses = { course, course1, course2 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);


}


CourseManager   courseManager = new (new EFCourseDal());

List<Course> courses2= courseManager.getCourseAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);


}


Console.WriteLine("kod bitti 1. gün "); 


IndividualCustomer customer = new IndividualCustomer();
customer.Id = 1;
customer.NationalIdentity = "12345678922";
customer.FirstName = "Aslı ";
customer.LastName = "Karaağaç";
customer.CustomerNumber = "123852";


IndividualCustomer customer1 = new IndividualCustomer();
customer.Id = 2;
customer.NationalIdentity = "45678975522";
customer.FirstName = "Özgür ";
customer.LastName = "Atılgan";
customer.CustomerNumber = "123782";


CoorparateCustomer customer2 = new CoorparateCustomer();

customer2.Id = 3;
customer2.Name = "Kodlama.io";
customer2.CustomerNumber = "946513";
customer2.TaxNumber = "12345678987";

CoorparateCustomer customer3 = new CoorparateCustomer();

customer3.Id = 3;
customer3.Name = "Ertas.io";
customer3.CustomerNumber = "946583";
customer3.TaxNumber = "12345678967";


BaseCustomer[] customers = { customer, customer1, customer2, customer3 };

foreach (BaseCustomer item in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}