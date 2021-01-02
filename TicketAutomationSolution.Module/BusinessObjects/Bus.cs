using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace TicketAutomationSolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Bus : XPObject
    {
        public Bus(Session session) : base(session)
        { }


        string _numberPlate;
        string _name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => _name;
            set => SetPropertyValue(nameof(Name), ref _name, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NumberPlate
        {
            get => _numberPlate;
            set => SetPropertyValue(nameof(NumberPlate), ref _numberPlate, value);
        }

        [Association("Bus-Tickets")]
        public XPCollection<Ticket> Tickets
        {
            get
            {
                return GetCollection<Ticket>(nameof(Ticket));
            }
        }

    }
}
