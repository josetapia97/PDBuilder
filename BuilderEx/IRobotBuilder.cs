using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEx
{
    //2
    //builder
    public interface IRobotBuilder
    {
        void BuildHead(string head);
        void BuildBody(string Body);
        void BuildArms(string arms);
        void BuildLegs(string legs);
        Robot GetRobot();
    }
}
