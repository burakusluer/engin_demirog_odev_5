using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace.Entities.Abstracts;
/// <summary>
/// shor summary as CV
/// CouseIdentities as go courses using it
/// </summary>
public interface IInstructor
{
    public int InstructorId { get; set; }
    public int NationalId { get; set; }
    public List<int> CourseIdentities { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CurriculumVitae { get; set; }//CV
}
