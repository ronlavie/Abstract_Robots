using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        public RobotFly(string model, DateTime creationDate, double batteryStatus) : base(model, creationDate, batteryStatus) 
        { }

        private void MoveLeg(int legId, int dir)
        {
            base.setStatus(base.getStatus() - 2);
            //3. הוסיפו התייחסות לסוללה
        }

        private void MoveWing(int wingId,int twoId)
        {
            base.setStatus(base.getStatus() - 1.5);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, 1);
        }

        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
            {
                this.MoveLeg(i, -1);
            }

        }

        public override void TurnLeft()
        {
            this.MoveLeg(1, -1);
            this.MoveLeg(2, -1);
            this.MoveLeg(3, 1);
            this.MoveLeg(4, 1);
        }

        public override void TurnRight()
        {
            this.MoveLeg(1, 1);
            this.MoveLeg(2, 1);
            this.MoveLeg(3, -1);
            this.MoveLeg(4, -1);
        }

        public  void fly(int id,int twoId)
        {
            MoveWing(id,twoId);
        }

    }
}
