using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Дефинирайте клас Student, който съдържа следната информация за студентите:
// трите имена, курс, специалност, университет, електронна поща и телефонен номер.

// Втора Част
// Декларирайте няколко конструктора за класа Student, които имат различни списъци с параметри
//(за цялостната информация за даден студент или част от нея). 
//Данните, за които няма входна информация да се инициализират съответно с null или 0.

//Трета част -  Добавете статично поле в класа Student, в което се съхранява броя на създадените обекти от този клас.

namespace StudentsClass
{
    class Students
    {

        public static int studenstCount = 0; //трета част - статично поле за борят на студентите
        
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

        /* Ако се създаде инстанция без параметри в конструктора на класа следва верижна реакция,
         * в която всеки следващ конструктор задава NULL параметър и извиква следващия чрез :this(...., ....)
         * 
         * Ако се създаде инстанция с един или повече параметъра - реакцията продължава,
         * от конструктора който е извикан и той предава на останалите елементи NULL 
         * до достигане на последния конструктор */

        public Students() 
            : this(null) { }                                        //Първият Конструктор извиква вторият със стойност NULL за FirstName
        
        public Students(string FirstName)
            : this(FirstName, null) { }                             //Вторият Конструктор извиква третият със стойност FirstName и NULL за MiddleName
        
        public Students(string FirstName, string MiddleName)
            : this(FirstName, MiddleName, null) { }                 //Третия Конструктор извиква четвъртият със стойност FirstName, MiddleName и NULL за LastName
        
        public Students(string FirstName, string MiddleName, string LastName)
            : this(FirstName, MiddleName, LastName, Year.First) { }
        
        public Students(string FirstName, String MiddleName, string LastName, Year IsInYear)
            : this(FirstName, MiddleName, LastName, IsInYear, University.MGU) { }
        
        public Students(string FirstName, string MiddleName, string LastName, Year IsInYear, University IsInUniversity)
            : this(FirstName, MiddleName, LastName, IsInYear, IsInUniversity, null) { }
        
        public Students(string FirstName, string MiddleName, string LastName, Year IsInYear, University IsInUniversity, string IsStuding)
            : this(FirstName, MiddleName, LastName, IsInYear, IsInUniversity, IsStuding, null) { }
        
        public Students(string FirstName, string MiddleName, string LastName, Year IsInYear, University IsInUniversity, string IsStuding, string EmailAddres)
            : this(FirstName, MiddleName, LastName, IsInYear, IsInUniversity, IsStuding, EmailAddres, 0) { }

        public Students(string FirstName, string MiddleName, string LastName, Year IsInYear, University IsInUniversity, string IsStuding, string EmailAddress, int PhoneNumber) 
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;

            this.IsInYear = IsInYear;
            this.IsInUniversity = IsInUniversity;

            this.IsStuding = IsStuding;
            this.EmailAddress = EmailAddress;
            this.PhoneNumber = PhoneNumber;

            studenstCount+= 1; //статично поле за броя на студентите създадени от класа
        }

        public void GetInfo()
        {
            Console.WriteLine("Name: {0}\n is in Year: \"{1}\"\n University: {2}\n Major: {3}\n email: {4}\n Phone: {5}",
                (FirstName +" "+ MiddleName +" "+ LastName), IsInYear, IsInUniversity, IsStuding, EmailAddress, PhoneNumber);
        }



       

    }
}
