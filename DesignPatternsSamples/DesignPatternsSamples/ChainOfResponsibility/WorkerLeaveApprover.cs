using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility
{
    public class WorkerLeaveApprover : LeaveApprover
    {
        public WorkerLeaveApprover()
        {
            companyPositionLevel = Position.Worker;
        }
    }
}
