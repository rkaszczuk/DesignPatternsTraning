using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility
{
    public class ManagerLeaveApprover : LeaveApprover
    {
        public ManagerLeaveApprover()
        {
            companyPositionLevel = Position.Manager;
        }
    }
}
