using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace.Business.Abstracts;
using WorkSpace.Dal.Abstracts;
using WorkSpace.Dal.Concretes;
using WorkSpace.Entities.Concretes;

namespace WorkSpace.Business.Concretes;

public class InstructorManager:IInstructorService
{
    IDummyDal<Instructor> _instructorDal;

    public InstructorManager()
    {
        _instructorDal = new InstructorDal();
    }

    public List<Instructor> getCourses()
    {
       return _instructorDal.GetDummyData();
    }
    
    public List<Instructor> getCourses(Func<Instructor, bool> filter)
    {
       return _instructorDal.GetDummyData(filter);
    }
}
