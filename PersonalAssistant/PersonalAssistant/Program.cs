using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalAssistant
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, George!");

            Reminder remainder1 = new Reminder("Първа Бележка", "Текст Към Бележката");

            ReminderWhitAlarm reminderAllarm = new ReminderWhitAlarm("Бележка с Дата", "", new DateTime(2013,11,11));
            ReminderWhitAlarm reminderAllarm2 = new ReminderWhitAlarm("Бележка с Дата", "", new DateTime(2013, 12, 12));


            // ReminderWhitAlarm reminderAllarm3 = new ReminderWhitAlarm("Бележка с Дата по стара от Днес", "", new DateTime(2012, 12, 12));
            // по горния ред хвърля грешка - заради валидацията на входа, ще е хубаво да намерим обиколен път при зареждане на данни от файл със стара дата


            Contact myContact = new Person("Georgi", "", "");  //ако някой може да го направи при създаването на обекта да може и да му се закача и бележка ще е супер

            Person mySecondContact = new Person("Stefan", "", "");
            Person myThirdContact = new Person("Stoyan", "Stoyanov", "Soenov");

            myThirdContact.AddNote(reminderAllarm);
            myThirdContact.AddNote(reminderAllarm2);




            List<Contact> contacts = new List<Contact>();

            contacts.Add(myThirdContact);
            contacts.Add(mySecondContact);
            contacts.Add(myContact);

            contacts.Sort(); //благодарение на интерфейса IComparable имплементиран в класа Contacts
            // много хубава статия по темата - http://dotnetslackers.com/Community/blogs/simoneb/archive/2007/06/20/How-to-sort-a-generic-List_3C00_T_3E00_.aspx
                        
            #region Търсена по Първо име в лист от контакти(contacts)
            
            var contactTofind = contacts.Find(x => x.FirstName.Equals("Stefan"));
            var contactTofind2 = contacts.FindAll(x => x.FirstName.StartsWith("St"));

            #endregion


            List<Note> notes = new List<Note>();
            notes.Add(reminderAllarm2);
            notes.Add(reminderAllarm);
            notes.Add(remainder1);
            // notes.Add(reminderAllarm3);


            #region Търсене по дата в лист от бележки(notes) има нужда от оправяне със сигурност
            //може да се използва за показване на алармите за деня например, сигурно трябва да се направи като метод някъде
            //тук само съм експериментирал как да се получи дисплея на бележките
            foreach (Note note in notes)
            {


                if (note is ReminderWhitAlarm)
                {
                    var result = (ReminderWhitAlarm)note;

                    if (result.Date > DateTime.Now)  //вместо това може да се парсва дата от входа на конзолата
                    {
                        Console.WriteLine("{0}, {1}, {2}", result.Title, result.Content, result.Date.ToShortDateString());
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("{0}, {1}", note.Title, note.Content);
                }

            } 
            #endregion


            #region Показване на всички бележки за контакта
            // показване на контакта заедно със всички бележки към него и аларми - най вероятно ще е добре ако се създаде като статичен метод
            // трябва да се направи показването на телефоните за контакта

            var listOfNotesInContect = myThirdContact.Note.FindAll(x => x.Equals(x));

            Console.WriteLine("{0}, {1} :", myThirdContact.FirstName, myThirdContact.LastName);

            foreach (var item in listOfNotesInContect)
            {
                if (item is ReminderWhitAlarm)
                {
                    var result = (ReminderWhitAlarm)item;
                    Console.WriteLine("{0}, {1}, {2}", result.Title, result.Content, result.Date.ToShortDateString());
                }
                else
                {
                    Console.WriteLine("{0}, {1}", item.Title, item.Content);
                }
            } 
            #endregion


            Gift myGift = new Gift(200, "Скъпичко ми излезна", "");

            
        }
    }
}