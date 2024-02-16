using Business.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{ 
public class PttManager: ISuplierService
    {

    private IAplicantService _aplicantService;


    public PttManager(IAplicantService aplicantService)
    {
        _aplicantService = aplicantService; 

    }
    public void GiveMask(Person person)  
    {

            if (_aplicantService.CheckPerson(person))
            {

                Console.WriteLine(person.FirstName + " için maske verildi ");

            }
            else
            {

                Console.WriteLine(person.FirstName + " için maske verilemedi");


            }


        }
}
}