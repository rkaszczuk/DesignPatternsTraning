using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility
{
    public class PresidentLeaveApprover : LeaveApprover
    {
        public PresidentLeaveApprover()
        {
            companyPositionLevel = Position.President;
        }
    }
}
