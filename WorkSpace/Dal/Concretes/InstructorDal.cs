using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace.Dal.Abstracts;
using WorkSpace.Entities.Concretes;

namespace WorkSpace.Dal.Concretes;

public class InstructorDal : IDummyDal<Instructor>
{
    List<Instructor> _instructors;

    public InstructorDal()
    {
        _instructors = new List<Instructor> 
        { 
            new Instructor{CourseIdentities={1,2,3,4,5,6 },CurriculumVitae="Iam a professional instructor .....",FirstName="Johny",LastName="Talker",InstructorId=2,NationalId=54332221},
            new Instructor{CourseIdentities={1,2,3,4,5,6,12 },CurriculumVitae="Iam a amateur instructor .....",FirstName="Jake",LastName="Snitch",InstructorId=21,NationalId=12225569},
        };
    }
    public List<Instructor> GetDummyData(Func<Instructor, bool> filter)
    {
        return _instructors.Where(filter ?? (c => true)).ToList();
    }

    public List<Instructor> GetDummyData()
    {
        return _instructors;
    }
}
