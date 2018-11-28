using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility
{
    public class DirectorLeaveApprover : LeaveApprover
    {
        public DirectorLeaveApprover()
        {
            companyPositionLevel = Position.Director;
        }
    }
}
