// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------------------------------Constructors--------------------\n\n\n");

Customer customer = new Customer { Id=1, FirstName="Engin ",LastName="Demiroğ" ,City="Ankara"};


Customer customer1 = new Customer(2, "Derin ", "Demiroğ", "Ankara");
class Customer {


    // Aynı anda 2 Constructor tanımlamaya Overloading denir ve methotla tanımlanan constructor  dan hariç tanımlama almak için kullanılır 
    public Customer()
    {
        
    }


    public Customer(int id , string firstName , string lastName , string city)
    {
        Id = id; 
        FirstName = firstName;
        LastName = lastName; 
        City = city;    

    }

    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string City { get; set; }
}
