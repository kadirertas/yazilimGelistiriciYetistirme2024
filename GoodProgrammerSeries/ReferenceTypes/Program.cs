// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int , decimal , boolean , flaoat ,enum  variables type
int sayi1 = 10; 
int sayi2 = 20; 

sayi1 = sayi2;
sayi2 = 100;
Console.WriteLine("sayı1 in değeri ::"+ sayi1);

//arrays class interface reference type 
int[] sayilar1 = new int[] { 1, 2, 3 };
int[] sayilar2 = new int[] { 10, 20, 30 };

sayilar1 = sayilar2;
sayilar2[0] = 20000;
Console.WriteLine("sayılar1 arrayinin 0 ıncı  değeri ::"+sayilar1[0]);

Person person1 = new Person();  
Person person2 = new Person();
Customer customer1 = new Customer();
customer1.FirstName = "Salih";
customer1.CreditCardNumber = "85218653265321"; 
Employe employe1 = new Employe();
employe1.FirstName = "Veli ";
 


person1.FirstName = "Engin";
person2 = person1;
person1.FirstName = "Derin";
Console.WriteLine(person2.FirstName);

Person person3 = customer1; 
Console.WriteLine(person3.FirstName);
Console.WriteLine(((Customer)person3).CreditCardNumber);


PersonManager personManager1 = new PersonManager();
personManager1.Add( employe1);
class Person {
        public int Id { get; set; }
       public string FirstName { get; set; }

      public string LastName { get; set; }
}
class Customer:Person {

    public string CreditCardNumber { get; set; }
}

class Employe : Person 
{ 
    public int EmployeNumber { get; set; }
}

class PersonManager 
{


    public void Add (Person person)
    {
        Console.WriteLine(person.FirstName) ;     
    }
}