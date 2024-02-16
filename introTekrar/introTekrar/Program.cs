// See https://aka.ms/new-console-template for more information
using introTekrar.Business;
using introTekrar.Enitites;

Console.WriteLine("Hello, World!");
string message = "Krediler"; 
int term = 12;
double amount = 10000.6; 
bool isAuthenticaiton= true;

if (isAuthenticaiton) 
{

    Console.WriteLine("Hoşgeldiniz"); 
}
else 
{
    Console.WriteLine("Lütfen Oturum Açın "); 

}

Console.WriteLine(message);
 

string[] Loans = { "kredi1", "kredi2", "kredi3", "kredi3", "kredi4"};  // bu veri db den gelecek 



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
course2.Description ="python3,12 ... VS";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 1;
course3.Name = "JAVA";
course3.Description = "Java 17 ... VS";
course3.Price = 20;


Course[] courses = { course1, course2, course3 };


for (int i = 0; i < courses.Length; i++)
{

    Console.WriteLine(courses[i].Name  +"  ///  " + courses[i].Price);

}

Console.WriteLine("----------------------------------Metotla Listeleme-------------------------"); 
CourseManager courseManager1 = new CourseManager();
Course[] courses2 =courseManager1.GetAll();
for (int i = courses2.Length - 1; i >= 0; i--)
{

    Console.WriteLine(courses2[i].Name + "  ///  " + courses2[i].Price);

}
Console.WriteLine("Kod Bitti...."); 