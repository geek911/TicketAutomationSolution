using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAutomationSolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Location : XPObject
    {
        public Location(Session session) : base(session)
        { }

        string _name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => _name;
            set => SetPropertyValue(nameof(Name), ref _name, value);
        }

        //[Association("Location-Tickets")]
        //public XPCollection<Ticket> Ticket
        //{
        //    get
        //    {
        //        return GetCollection<Ticket>(nameof(Ticket));
        //    }
        //}

    }
}
