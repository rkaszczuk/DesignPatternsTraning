using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility
{
    public enum Position { Worker, Manager, Director, President}
    public abstract class LeaveApprover
    {
        protected Position companyPositionLevel;
        protected LeaveApprover superiorApprover;
        public void SetSuperior(LeaveApprover superior)
        {
            superiorApprover = superior;
        }
        public bool ApproveLeave(Position position)
        {
            if(position < companyPositionLevel)
            {
                Console.WriteLine("Approve! " + this.GetType().Name);
                return true;
            }
            else if(superiorApprover!=null)
            {
                return superiorApprover.ApproveLeave(position);
            }
            return false;
        }
    }
}
