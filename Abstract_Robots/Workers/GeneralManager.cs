using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        //1. השלימות את התכונות החסרות
        protected bool isBonus;
        protected double Bonus;
        protected double monthlySalary;
        protected double hourswork;
        protected double hourpay;

        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlySalary,double bonus)
            :base (name,id,bDate,pass)
        {
            //2. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
        }
        public double Monthly()
        {
            double sum = 0;
            if (isBonus)
            {
                sum = Bonus + monthlySalary;
            }
            else
                sum = monthlySalary;
            return sum;
        }
        public override double salary()
        {
            return Monthly();
        }

        //3. כתבו פעולה דורסת לחישוב שכר

    }
}
