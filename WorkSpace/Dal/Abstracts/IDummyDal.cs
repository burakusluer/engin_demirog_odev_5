using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace.Entities.Concretes;

namespace WorkSpace.Dal.Abstracts;
/// <summary>
/// the class for simulate dummy DB operations
/// To use you need to create private List<T> _name list and return through the implemented functions
/// we gathering data from direct db filtered
/// the overload of the GetCourses needed. Becauses we can get All or needs to be a filtered one's
/// ı dont add update,insert,delete cruds because not yet use database 
/// </summary>
public interface IDummyDal<T>
{
  
    public List<T> GetDummyData(Func<T, bool> filter);
	public List<T> GetDummyData();

}
