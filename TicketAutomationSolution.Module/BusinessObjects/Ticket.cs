using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace TicketAutomationSolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Ticket : XPObject
    {
        public Ticket(Session session) : base(session)
        { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            DateTime = DateTime.Now;
        }


        Bus _bus;
        string _ticketNumber;
        string _conductor;
        decimal _amount;
        PassengerType _passengerType;
        TicketType _ticketType;
        Location _endStation;
        Location _startStation;
        DateTime _dateTime;

        public DateTime DateTime
        {
            get => _dateTime;
            set => SetPropertyValue(nameof(DateTime), ref _dateTime, value);
        }



        //[Association("Location-Tickets")]
        public Location StartStation
        {
            get => _startStation;
            set => SetPropertyValue(nameof(StartStation), ref _startStation, value);
        }



        //[Association("Location-Tickets")]
        public Location EndStation
        {
            get => _endStation;
            set => SetPropertyValue(nameof(EndStation), ref _endStation, value);
        }


        public TicketType TicketType
        {
            get => _ticketType;
            set => SetPropertyValue(nameof(TicketType), ref _ticketType, value);
        }


        public PassengerType PassengerType
        {
            get => _passengerType;
            set => SetPropertyValue(nameof(PassengerType), ref _passengerType, value);
        }


        public decimal Amount
        {
            get => _amount;
            set => SetPropertyValue(nameof(Amount), ref _amount, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Conductor
        {
            get => _conductor;
            set => SetPropertyValue(nameof(Conductor), ref _conductor, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string TicketNumber
        {
            get => _ticketNumber;
            set => SetPropertyValue(nameof(TicketNumber), ref _ticketNumber, value);
        }

        
        [Association("Bus-Tickets")]
        public Bus Bus
        {
            get => _bus;
            set => SetPropertyValue(nameof(Bus), ref _bus, value);
        }

    }
}
