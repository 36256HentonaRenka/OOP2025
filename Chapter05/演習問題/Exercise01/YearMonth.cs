using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01{
    //5.1.1
    public　class YearMonth{

        public int Year { get; set; }
        public int Month{ get; set; }

        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }

        //5.1.2
        public bool Is21Century => 2001 <= Year && Year <= 2100;

        //5.1.3
        public YearMonth AddOneMonth() {
            int newYear = Year;
            int newMonth = Month;

            if (newMonth == 12) {
                newMonth = 1;
                newYear++;
            } else {
                newMonth++;
            }
            return new YearMonth(newYear, newMonth);
        }
            

        //5.1.4
        public override string ToString() {
            

            return base.ToString();
        }

    }
}
