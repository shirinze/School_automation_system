using OBYS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Model.Entities
{
    public class Student : CoreEntity
    {
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string Gender { get; set; }
    }
}
