using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{
    //4
    //Director
    public class RobotDirector
    {
        private IRobotBuilder _robotBuilder;
        public RobotDirector(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }
        public void ConstructRobot()
        {
            _robotBuilder.BuildHead("Redonda");
            _robotBuilder.BuildBody("Metal");
            _robotBuilder.BuildArms("Claws");
            _robotBuilder.BuildLegs("Wheels");

        }
    }
}
