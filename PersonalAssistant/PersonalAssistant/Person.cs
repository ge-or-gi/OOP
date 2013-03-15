using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAssistant
{
    // Here we have a problem, because base class does not have parameterless constructor:
    class Person : Contact
    {
        public enum sex { Male, Female }; //енум за да угодим на условието - трябва да се имплементира към класа в момента никъде не се използва

        private List<string> _phone = new List<string>();       // лист от телефони може да са повече от един
        private List<Note> _note = new List<Note>();            //лист от бележки за конкретния човек, или апоинтмент ?!!!?!! (може би нетрябва)
        private List<string> _email = new List<string>();       // лист от емайли може да са повече от един

        public List<string> Phone
        {
          get { return _phone; }
          set { _phone = value; }
        }
        
        public List<string> Email
        {
          get { return _email; }
          set { _email = value; }
        }
       
        internal List<Note> Note
        {
          get { return _note; }
          set { _note = value; }
        }

        public Person(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        { }

        

        public void AddEmail(string email)
        {
            Email.Add(email);
        }

        public void AddNote(Note note)
        {
            Note.Add(note);
        }

        
    }
}
