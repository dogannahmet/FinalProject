using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        
        public CategoryManager(ICategoryDal categoryDal)
        {
            //categorymanager olarak veri erişim katmanına bağımlıyım. Interface üzerinden.
            //kurallarıma uyduğun sürece dataaccess katmanında isteğini yapabilirsin.
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            return new SuccessDataResult<List<Category>> (_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            //Select * from Categories where CategoryId = 3 (sql'de bu demek)
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        
        
    }
}
