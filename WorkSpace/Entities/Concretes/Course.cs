using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace.Entities.Abstracts;

namespace WorkSpace.Entities.Concretes;
/// <summary>
/// limit as student limit
/// CourseLevel means which skills or preperation needed for this course
/// EstimatedHours the amount of time as hours you think it's going to take
/// </summary>
public class Course : ILesson
{
    public int LessonId { get; set; }
    public string LessonName { get; set; }
    public string LessonDescription { get; set; }
    public List<int> CategoryIdentities { get; set; }
    public List<int> InstructorIdentities { get; set; }
    public int Limit { get; set; }
    public float EstimatedHours { get; set; } = 10;
    public CourseLevel CourseLevel { get; set; }
}

public enum CourseLevel{
    starter_infrastucture,junior,middle,senior,all
}