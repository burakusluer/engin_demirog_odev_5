using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace.Dal.Abstracts;
using WorkSpace.Entities.Concretes;

namespace WorkSpace.Dal.Concretes;

public class CategoryDal : IDummyDal<Category>
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category> 
        { 
            new Category{CategoryId=1,CategoryName="Software Engineering",CategoryDescription="Software architectures, design patterns, determines how to develop and which technologies are we need to use"},
            new Category{CategoryId=2,CategoryName="Algorithms & Data Structures",CategoryDescription="Its better start with algorithms before starting a developer way"},
            new Category{CategoryId=3,CategoryName="Computer Science History",CategoryDescription="Hail to you Charles Babbage & hail Ada Lovelace"}
        };
    }
    public List<Category> GetDummyData(Func<Category, bool> filter)
    {
        return _categories.Where(filter ?? (c=>true)).ToList();
    }

    public List<Category> GetDummyData()
    {
        return _categories;
    }
}
