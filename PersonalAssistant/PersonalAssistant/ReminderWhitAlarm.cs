using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAssistant
{
    class ReminderWhitAlarm : Reminder
    {

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Allarm for past Date is not Acceptable");
                    // при доавяне на дата по стара от текущата хвърля грешка, проблема ще е ако се зареждат от файл
                    // как ще се обработват старите бележки създадени по рано от текущата дата.
                }
                else
                {
                    _date = value;
                }
            }
        }

        public ReminderWhitAlarm(string title, string content, DateTime date)
            : base(title, content)
        {
            this.Date = date;
        }
    }
}
