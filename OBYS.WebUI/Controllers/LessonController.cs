using Microsoft.AspNetCore.Mvc;
using OBYS.Core.Service;
using OBYS.Model.Entities;
using System.Linq;

namespace OBYS.WebUI.Controllers
{
    public class LessonController : Controller
    {
        private readonly ICoreService<Lesson> _les;

        public LessonController(ICoreService<Lesson> les)
        {
            _les = les;
        }

        // Metodun amacı kayıtları liste olarak göstermek
        public IActionResult Listele()
        {
            return View(_les.GetAll());
        }

        // Metodun amacı yeni kayıt ekleme sayfasını göstermek
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Lesson l)
        {
            if (l.LessonName != null)
            {
                return _les.Add(l) ? View("Listele", _les.GetAll()) : View();
            }

            ViewBag.LessonAddError = "Ders Adını Boş Geçemezsiniz";
            return View();
        }

        public IActionResult Guncelle(int id)
        {
            return View(_les.GetByID(id));
        }

        [HttpPost]
        public IActionResult Guncelle(Lesson l)
        {
            if (l.LessonName != null)
            {
                return _les.Update(l) ? View("Listele", _les.GetAll()) : View();
            }

            ViewBag.LessonUpdateError = "Ders Adını boş bırakamazsınız";
            return View();
        }

        public IActionResult Sil(int id)
        {
            return _les.Delete(id) ? View("Listele", _les.GetAll()) : View();
        }
    }
}
