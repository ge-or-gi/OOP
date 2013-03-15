using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAssistant
{
    abstract class Contact : IComparable<Contact>
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;

        public string FirstName
        {
          get { return _firstName; }
          set 
          {
              if (string.IsNullOrWhiteSpace(value))
              {
                  throw new ArgumentNullException();
              }
              else
              {
                  _firstName = value;
              }
              
          }
        } 
        

        public string MiddleName
        {
          get { return _middleName; }
          set { _middleName = value; }
        } //има нужда да се въведе валидация за входа


        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        } //има нужда да се въведе валидация за входа


        #region constructors
        // Only the first name is required to create a contact;
        public Contact(string firstName)
            :this(firstName, null, null)
        {
        }

        public Contact(string firstName, string middleName, string lastName)  //за съдаването на контакт ще има нужда само от Първо Име, другите нулл по дефолт
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
        #endregion 


        
    
        public int CompareTo(Contact other)  //имплементация на интерфейса ICompareble за да може да изплозваме Sort на контактите иначе ще са разбъркани
                                             // ако се показват със foreach (дисплей на всички контакти в конзолата)
        {
            return FirstName.CompareTo(other.FirstName);
        }
    }
}
