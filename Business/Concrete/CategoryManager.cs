using Business.Abstract;
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

        public List<Category> GetAll()
        {
            //İş kodları
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            //Select * from Categories where CategoryId = 3 (sql'de bu demek)
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
