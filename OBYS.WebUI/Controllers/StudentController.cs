using Microsoft.AspNetCore.Mvc;
using OBYS.Core.Service;
using OBYS.Model.Entities;

namespace OBYS.WebUI.Controllers
{
    public class StudentController : Controller
    {
        private readonly ICoreService<Student> _stu;

        public StudentController(ICoreService<Student> stu)
        {
            _stu= stu;
        }

        public IActionResult Listele()
        {
            return View(_stu.GetAll());
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Student s)
        {
            if (s.StudentName != null && s.StudentSurname != null && s.Gender != null)
            {
                return _stu.Add(s) ? View("Listele", _stu.GetAll()) : View();
            }

            ViewBag.StudentAddError = "İsim, Soyisim ve Cinsiyet boş geçilemez";
            return View();
        }

        public IActionResult Guncelle(int id)
        {
            return View(_stu.GetByID(id));
        }

        [HttpPost]
        public IActionResult Guncelle(Student s)
        {
            if (s.StudentName != null && s.StudentSurname != null && s.Gender != null)
            {
                return _stu.Update(s) ? View("Listele", _stu.GetAll()) : View();
            }

            ViewBag.StudentUpdateError = "İsim, Soyisim ve Cinsiyet boş geçilemez";
            return View();
        }

        public IActionResult Sil(int id)
        {
            return _stu.Delete(id) ? View("Listele", _stu.GetAll()) : View();
        }
    }
}
