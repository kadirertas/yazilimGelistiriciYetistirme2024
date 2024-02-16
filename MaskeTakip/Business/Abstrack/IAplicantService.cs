using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstrack;

public interface IAplicantService
{

    public void ApplyForMask(Person person); //Maske İçin Başvur



    public List<Person> GetList();
    public bool CheckPerson(Person person);


}
