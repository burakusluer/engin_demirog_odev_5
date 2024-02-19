using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace.Dal.Abstracts;
using WorkSpace.Entities.Concretes;

namespace WorkSpace.Dal.Concretes;

public class CourseDal : IDummyDal<Course>
{
    List<Course> _courses;
    public CourseDal()
    {
        _courses = new List<Course> 
        { 
            new Course{CategoryIdentities=new List<int> {1,2,3,4,5},CourseLevel=CourseLevel.all,EstimatedHours=90,InstructorIdentities=new List<int> {1,2,3,4,5,6},LessonDescription="lorem ipsum dolor sit amet",LessonId=1,LessonName="CSC50",Limit=5} ,
            new Course{ CategoryIdentities=new List<int> {2,3,4,5},CourseLevel =CourseLevel.middle,EstimatedHours=1,InstructorIdentities=new List<int> {3,4,5},LessonDescription="Lorem",LessonName="CSC15",LessonId=5,Limit=100}
        };
     }
    public List<Course> GetDummyData(Func<Course, bool> filter)
    {
        return _courses.Where(filter ?? (c => true)).ToList();
    }

    public List<Course> GetDummyData()
    {
        return _courses;
    }

}
