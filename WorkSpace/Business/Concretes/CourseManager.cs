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

public class CourseManager:ICourseService
{
    IDummyDal<Course> _courseDal;

    public CourseManager()
    {
        _courseDal = new CourseDal();
    }

    public List<Course> getCourses()
    {
       return _courseDal.GetDummyData();
    }
    
    public List<Course> getCourses(Func<Course, bool> filter)
    {
       return _courseDal.GetDummyData(filter);
    }
}
