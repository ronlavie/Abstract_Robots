using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private string model;
		private DateTime creationDate;
		private double batteryStatus; 

		//1. עדכנו את הפעולה הבונה כך שתקבל פרמטרים בהתאם לתכונות
		public RobotSpy(string model,DateTime creationDate,double batteryStatus)
		{
			this.model = model;
			this.batteryStatus = batteryStatus;
			this.creationDate = creationDate;
		}
		public string GetModel() { 	return this.model; }

        //2. השלימו פעולות מאחזרות עבור התכונות הנוספות
        //3. הוסיפו פעולה המעדכנת את מצב הסוללה
		public double getStatus()
		{
			return this.batteryStatus;
		}
        public void setStatus(double x)
		{
			this.batteryStatus = x;
		}
		public string getModel()
		{
			return model;
		}
		public DateTime getDate()
		{
			return creationDate;
		}
        public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture() 
		{
			this.batteryStatus -= 5;
		} //4. הוסיפו התייחסות למצב סוללה
		public void ChargeBattery() 
		{
			this.batteryStatus = 100;
		} //5. עדכנו את מצב הסוללה ל-100
	}
}
