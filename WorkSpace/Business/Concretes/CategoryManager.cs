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

public class CategoryManager:IInstructorService
{
    IDummyDal<Category> _categoryDal;

    public CategoryManager()
    {
        _categoryDal = new CategoryDal();
    }

    public List<Category> getCourses()
    {
       return _categoryDal.GetDummyData();
    }
    
    public List<Category> getCategories(Func<Category, bool> filter)
    {
       return _categoryDal.GetDummyData(filter);
    }
}
