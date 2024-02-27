using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Entities; 

public class Course
{

    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string CourseName { get; set; }
    public decimal UnitPrice { get; set; }
    public bool  joined { get; set; }
}
