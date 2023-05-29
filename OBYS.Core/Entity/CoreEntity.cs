using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Core.Entity
{
    // CoreEntity sınıfı tablo olarak oluşacak sınıflara base class görevini yerine getirecek
    // ? işareti bu alanın boş geçilebilir alan olduğu anlamına gelir
    public class CoreEntity
    {
        public int ID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
