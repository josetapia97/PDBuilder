using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{
    //3
    //concrete builder
    public class RobotBuilder : IRobotBuilder
    {
        private Robot _robot = new Robot();
        public void BuildArms(string arms)
        {
            _robot.Arms = arms;
        }

        public void BuildBody(string Body)
        {
            _robot.Body = Body;
        }

        public void BuildHead(string head)
        {
            _robot.Head = head;
        }

        public void BuildLegs(string legs)
        {
            _robot.Legs = legs;
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
