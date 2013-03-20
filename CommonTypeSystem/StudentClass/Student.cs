using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get;  set; }
        public string MiddleName { get;  set; }
        public string LastName { get; private set; }
        public int SSN { get; private set; }
        public string PermanentAdress { get; private set; }
        public string MobilePhone { get; private set; }
        public string Email { get; private set; }
        public byte Course { get; private set; }
        public University UniversityName { get; private set; }
        public Faculty FacultyName { get; private set; }
        public Specialty SpecialtyName { get; private set; }

        public Student(string fName, string mName, string lName, int studentSerialNumber, string permanentAddress, string phone,
            string email, University university, Faculty faculty, Specialty specialty, byte course)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = studentSerialNumber;
            this.PermanentAdress = permanentAddress;
            this.MobilePhone = phone;
            this.Email = email;
            this.UniversityName = university;
            this.FacultyName = faculty;
            this.SpecialtyName = specialty;
            this.Course = course;
        }
        

        public override bool Equals(object param)
        {
            bool isEqual = true;

            Student student = param as Student;
            if (student == null)
            {
                isEqual = false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                isEqual = false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                isEqual = false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                isEqual = false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                isEqual = false;
            }
            return isEqual;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Student: {0} {2} {1}", this.FirstName, this.LastName, this.MiddleName));
            result.AppendLine("SSN: " + this.SSN);
            result.AppendLine("Address: " + this.PermanentAdress);
            result.AppendLine("MobilePhone: " + this.MobilePhone);
            result.AppendLine("Email: " + this.Email);
            result.AppendLine("Course: " + this.Course);
            result.AppendLine("Speciality: " + this.SpecialtyName);
            result.AppendLine("University: " + this.UniversityName);
            result.AppendLine("Faculty: " + this.FacultyName);

            return result.ToString();
        }

        public Student Clone()
        {

            Student result = new Student(FirstName, MiddleName, LastName, SSN, PermanentAdress,
                MobilePhone, Email, UniversityName, FacultyName, SpecialtyName, Course);
            return result;
        }

        Object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return (this.FirstName.CompareTo(other.FirstName));
            }
            if (this.MiddleName != other.MiddleName)
            {
                return (this.MiddleName.CompareTo(other.MiddleName));
            }
            if (this.LastName != other.LastName)
            {
                return (this.LastName.CompareTo(other.LastName));
            }
            if (this.SSN != other.SSN)
            {
                return (this.SSN - other.SSN);
            }
            return 0;
        }
    }
}
