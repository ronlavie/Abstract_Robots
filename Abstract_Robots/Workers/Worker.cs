using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
        }


        public string getName()
        {
            return this.fullName;
        }

        public string FullName { get { return fullName; } }

        public string getpass()
        {
            return this.password;
        }


        public DateTime getBirth()
        {
            return this.birthDate;
        }
        public void setPass(string pass)
        {
            this.password = pass;
        }

        public string getId()
        {
            return this.idNumber;
        }

        public override string ToString()
        {
            string str = "";
            if (birthDate.Equals(DateTime.Today))
                str = " - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
        public abstract double salary();
    }
}
