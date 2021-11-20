using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_list
{
    public class PhoneTalk
    {
        public string SecondName { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DateTalk { get; set; }
        public int TraficPerMin { get; set; }
        public TimeSpan Begin { get; set; }
        public TimeSpan End { get; set; }

        public PhoneTalk()
        {

        }
        public PhoneTalk(string secondName, long phonenumber, DateTime dateTalk, int trafic, TimeSpan begin, TimeSpan end )
        {
            SecondName = secondName;
            PhoneNumber = phonenumber;
            DateTalk = dateTalk;
            TraficPerMin = trafic;
            Begin = begin;
            End = end;
        }

        public override string ToString()
        {
            return $"secondname: {SecondName}";
        }

    }
}
