using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introTekrar.Enitites;

public class IndividualCustomer:BaseCustomer    //BireyselMüsteri
{

   
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }   //Tc Kimlik
}
