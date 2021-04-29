using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // static olmasının nedeni new()'lenmesine ihtiyaç duyulmaması için. Çünkü sabit bölüm.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductUpdated = "Ürünler güncellendi.";
        public static string ProductCountOfCategoryError = "Limit aşımı";
        public static string ProductNameAlreadyExists = "Aynı ürün ismi tekrarlanamaz";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}
