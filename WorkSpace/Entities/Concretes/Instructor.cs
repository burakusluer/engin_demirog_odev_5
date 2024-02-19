using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace.Entities.Abstracts;

namespace WorkSpace.Entities.Concretes;

public class Instructor : IInstructor
{
    public int InstructorId { get; set; }
    public int NationalId { get; set; }
    public List<int> CourseIdentities { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CurriculumVitae { get; set; }
}
