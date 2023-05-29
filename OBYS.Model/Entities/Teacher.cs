using OBYS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Model.Entities
{
    public class Teacher : CoreEntity
    {
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public int LessonID { get; set; } // fdgf4g48554fg45f5g454fg54fg45f45g45f4g --> Guid
        public Lesson Lesson { get; set; } // 1-1 ilişki
    }
}
