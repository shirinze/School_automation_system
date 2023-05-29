using OBYS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Core.Service
{
    // ICoreService interface kullanılacak sql sorgu yazımlarının tanımlarının yapıldığı arayüzdür.
    // T ifadesi burada CoreEntity'den miras almış bir sınıfı temsil etmektedir.
    public interface ICoreService<T> where T : CoreEntity
    {
        // Crud => Create, Read, Update, Delete
        bool Add(T item); // Ekleme
        bool Delete(int id); // Silme
        bool Update(T item); // Güncelleme
        T GetByID(int id); // Tabloya göre tek kayıt getirme
        List<T> GetAll(); // Tabloya göre bütün kayıtları getirme
        int Save(); // SaveChanges()
    }
}
