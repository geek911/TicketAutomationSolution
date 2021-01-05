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

        [NonPersistent]
        public decimal TodaySales
        {
            get
            {
                var total = Tickets.Where(t => t.DateTime.Date == DateTime.Today.Date).Sum(t => t.Amount);
                return total;
            }
        }
        [NonPersistent ]
        public decimal ThisMonthSales
        {
            get
            {

                var total = Tickets.Where(t => t.DateTime.Year == DateTime.Today.Year && t.DateTime.Month == DateTime.Today.Month).Sum(t => t.Amount);
                return total;
            }
        }

        [NonPersistent]
        public decimal TotalSalesThisYear
        {
            get
            {
                var total = Tickets.Where(t => t.DateTime.Year == DateTime.Today.Year).Sum(t => t.Amount);
                return total;

            }
        }

        [Association("Bus-Tickets")]
        public XPCollection<Ticket> Tickets
        {
            get
            {
                return GetCollection<Ticket>(nameof(Tickets));
            }
        }

    }
}
