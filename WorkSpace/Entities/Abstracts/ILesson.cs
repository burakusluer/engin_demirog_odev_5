using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace.Entities.Abstracts;
/// <summary>
/// CategoryIdentities:The courses or other type of lessons can have multiple categories
/// InstructorIdentities:The courses or other type of lessons can have multiple instructors
/// </summary>
public interface ILesson
{
    public int LessonId { get; set; }
    public string LessonName { get; set; }
    public string LessonDescription { get; set; }
    public List<int> CategoryIdentities { get; set; }
    public List<int> InstructorIdentities { get; set; }
}
