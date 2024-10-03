using System.Collections.Generic;
using System.Xml.Serialization;



namespace BettingRecordApp
{
    public class Event
    {
        public EventInfo EventInfo { get; set; }
        public SportInfo SportInfo { get; set; }
        public BetInfo BetInfo { get; set; }
        public EVENT_STATUS Status { get; set; }

        public Event()
        {
            // NOTHING
        }

        public Event(EventXML _eventXML)
        {
            EventInfo = new EventInfo(_eventXML.EventInfo);
            SportInfo = new SportInfo(_eventXML.SportInfo);
            BetInfo = new BetInfo(_eventXML.BetInfo);
            Status = UtilityCommon.ParseEnum<EVENT_STATUS>(_eventXML.Status);
        }
    }



    public class EventXML
    {
        [XmlElement("EventInfo")]
        public EventInfoXML EventInfo { get; set; }
        [XmlElement("SportInfo")]
        public SportInfoXML SportInfo { get; set; }
        [XmlElement("BetInfo")]
        public BetInfoXML BetInfo { get; set; }
        [XmlElement("Status")]
        public string Status { get; set; }

        public EventXML()
        {
            // NOTHING
        }

        public EventXML(Event _event)
        {
            EventInfo = new EventInfoXML(_event.EventInfo);
            SportInfo = new SportInfoXML(_event.SportInfo);
            BetInfo = new BetInfoXML(_event.BetInfo);
            Status = _event.Status.ToString();
        }
    }



    public class EventTableInfo
    {
        public string DateTime { get; set; }
        public string EventInfo { get; set; }
        public string SportInfo { get; set; }
        public string BetInfo { get; set; }
        public string Odds { get; set; }
        public string Status { get; set; }

        public EventTableInfo(Event _event)
        {
            DateTime = _event.EventInfo.DateTime.ToString(CommonConstants.DATE_TIME_FORMAT);
            EventInfo = $"{_event.EventInfo.Away} @ {_event.EventInfo.Home}";
            SportInfo = $"{_event.SportInfo.League}, {_event.SportInfo.Sport}";
            BetInfo = $"{_event.BetInfo.BetCategory}, {_event.BetInfo.Bet}";
            Odds = _event.BetInfo.Odds.ToString("F2");
            Status = _event.Status.ToString();
        }
    }
}
