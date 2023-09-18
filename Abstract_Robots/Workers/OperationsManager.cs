using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        //1. השלימות את התכונות החסרות

        private double hourPay;
        private double hoursWork;
        private double bonus;
        private bool isWork;
        public OperationManager(string name, string id, DateTime bDate, string pass,int hourpay,int hourswork,double bonus)
            : base(name, id, bDate, pass ) 
        {
         

        }

        //2. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
        
        public double plus()
        {
            
            double sum = 0;
            if (isWork)
                sum = bonus + (hourPay * hoursWork);
            else
                sum = hourPay * hoursWork;
            return sum;
        }

        //3. כתבו פעולה דורסת לחישוב שכר
        public override double salary()
        {
            return plus();
        }
    }
}
