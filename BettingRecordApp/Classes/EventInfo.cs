using System;
using System.Xml.Serialization;



namespace BettingRecordApp
{
    public class EventInfo
    {
        public DateTime DateTime { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }

        public EventInfo()
        {
            // NOTHING
        }

        public EventInfo(EventInfoXML _eventInfoXML)
        {
            DateTime = DateTime.ParseExact(_eventInfoXML.DateTime, CommonConstants.DATE_TIME_FORMAT, null);
            Home = _eventInfoXML.Home;
            Away = _eventInfoXML.Away;
        }
    }



    public class EventInfoXML
    {
        [XmlAttribute("DateTime")]
        public string DateTime { get; set; }
        [XmlAttribute("Home")]
        public string Home { get; set; }
        [XmlAttribute("Away")]
        public string Away { get; set; }

        public EventInfoXML()
        {
            // NOTHING
        }

        public EventInfoXML(EventInfo _eventInfo)
        {
            DateTime = _eventInfo.DateTime.ToString(CommonConstants.DATE_TIME_FORMAT);
            Home = _eventInfo.Home;
            Away = _eventInfo.Away;
        }
    }
}
