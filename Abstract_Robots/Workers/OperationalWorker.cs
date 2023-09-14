using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker //1. כתבו את המחלקה המתאימה להורשה 
    {

        private double hourPay;
        private double hoursWork;//2. השלימות את התכונות החסרות

        public OperationalWorker(string name, string id, DateTime bDate, string pass,double hourPay)
            : base(name, id, bDate, pass,hourPay)
        {
            this.hourPay = hourPay;
            this.hoursWork = hoursWork;
                                //3. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
                               // ?האם נדרשים פרמטרים נוספים
        }

        public int money(int hourPay, int hoursWork)
        {
          int sum = 0;

            sum = hoursWork * hourPay;

            return sum;
        }//4. כתבו פעולה דורסת לחישוב שכר

    }
}
