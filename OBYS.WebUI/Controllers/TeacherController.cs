using Microsoft.AspNetCore.Mvc;
using OBYS.Core.Service;
using OBYS.Model.Entities;

namespace OBYS.WebUI.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ICoreService<Teacher> _t;

        public TeacherController(ICoreService<Teacher> t)
        {
            _t = t;
        }

        public IActionResult Listele()
        {
            return View(_t.GetAll());
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Teacher t)
        {
            if (t.TeacherName != null && t.TeacherSurname != null)
            {
                return _t.Add(t) ? View("Listele", _t.GetAll()) : View();
            }

            return View();
        }
    }
}
