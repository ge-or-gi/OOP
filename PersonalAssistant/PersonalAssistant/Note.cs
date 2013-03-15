using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAssistant
{
    public abstract class Note 
    {
        private string _title;
        private string _content;
        
        //може да трябва да се сложи един field - _dateCreated - който се попълва автоматично при създаване на Note или наследниците на класа
        //след това може да се сортират по дата на създаване (не по дата на алармата)


        public string Content           // има нужда от валидация на входа
        {
            get { return _content; }
            set { _content = value; }
        }

        public string Title             
        {
            get { return _title; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title must have Content");
                }
                else
                {
                    _title = value;      
                } 
            }
        }


        public Note(string title, string content) 
        {
            this.Title = title;
            this.Content = content;
        }

       
    }
}
