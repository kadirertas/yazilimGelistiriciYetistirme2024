using Business.Concrete;
using Entities.Concrete;





            







            Person person = new Person();
                 person.FirstName = "Kadir";
                 person.LastName = "Ertaş";
                 person.DateOfBirthYear = 2001;
                 person.NationalIdentity = 11223344556;
            Person person2 = new Person();
             person2.FirstName = "Murat"; 








       PttManager pttManager = new PttManager(new PersonManager());
          pttManager.GiveMask(person);





           
    

        
   





