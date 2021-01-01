using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace TicketAutomationSolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Employee : User
    {
        public Employee(Session session) : base(session)
        { }


    }
}
