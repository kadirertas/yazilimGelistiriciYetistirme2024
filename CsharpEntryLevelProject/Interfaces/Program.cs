// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


interface IPerson 
{
     int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }


}

class Customer :IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string  Adress { get; set; }
}



class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departman  { get; set; }

}

class  PersonManager 
{



    public void Add (IPerson person ) 
    {
        Console.WriteLine(person); 
    
    }

}


