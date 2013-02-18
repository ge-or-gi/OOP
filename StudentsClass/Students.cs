using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Дефинирайте клас Student, който съдържа следната информация за студентите:
// трите имена, курс, специалност, университет, електронна поща и телефонен номер.

namespace StudentsClass
{
    class Students
    {

        public enum Year
        {
            First, Second, Third, Forth, Fifth, Sixst
        }

        public enum University
        {
            MGU, TUSofia, SU
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Year IsInYear { get; set; }
        public University IsInUniversity { get; set; }

        public string IsStuding { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }


    }
}
