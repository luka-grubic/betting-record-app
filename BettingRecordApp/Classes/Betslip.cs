using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;



namespace BettingRecordApp
{
    public class Betslip
    {
        public string ID { get; set; }
        public string Provider { get; set; }
        public DateTime Date { get; set; }
        public decimal Wager { get; set; }
        public decimal PossiblePayout { get; set; }
        public decimal Payout { get; set; }
        public decimal TotalOdds { get; set; }
        public int EventCount { get; set; }
        public BETSLIP_STATUS Status { get; set; }
        public List<Event> Events { get; set; }

        public Betslip()
        {
            Events = new List<Event>();
        }

        public Betslip(BetslipXML _betslipXML)
        {
            ID = _betslipXML.ID;
            Provider = _betslipXML.Provider;
            Date = DateTime.ParseExact(_betslipXML.Date, CommonConstants.DATE_FORMAT, null);
            Wager = Convert.ToDecimal(_betslipXML.Wager);
            PossiblePayout = Convert.ToDecimal(_betslipXML.PossiblePayout);
            Payout = Convert.ToDecimal(_betslipXML.Payout);
            TotalOdds = Convert.ToDecimal(_betslipXML.TotalOdds);
            EventCount = Convert.ToInt16(_betslipXML.EventCount);
            Status = UtilityCommon.ParseEnum<BETSLIP_STATUS>(_betslipXML.Status);
            Events = _betslipXML.Events.Select(e => new Event(e)).ToList<Event>();
        }
    }



    public class BetslipXML
    {
        [XmlElement("ID")]
        public string ID { get; set; }
        [XmlElement("Provider")]
        public string Provider { get; set; }
        [XmlElement("Date")]
        public string Date { get; set; }
        [XmlElement("Wager")]
        public string Wager { get; set; }
        [XmlElement("PossiblePayout")]
        public string PossiblePayout { get; set; }
        [XmlElement("Payout")]
        public string Payout { get; set; }
        [XmlElement("TotalOdds")]
        public string TotalOdds { get; set; }
        [XmlElement("EventCount")]
        public string EventCount { get; set; }
        [XmlElement("Status")]
        public string Status { get; set; }
        [XmlArray("Events")]
        [XmlArrayItem("Event")]
        public List<EventXML> Events { get; set; }

        public BetslipXML()
        {
            // NOTHING
        }

        public BetslipXML(Betslip _betslip)
        {
            ID = _betslip.ID;
            Provider = _betslip.Provider;
            Date = _betslip.Date.ToString(CommonConstants.DATE_FORMAT);
            Wager = _betslip.Wager.ToString("F2");
            PossiblePayout = _betslip.PossiblePayout.ToString("F2");
            Payout = _betslip.Payout.ToString("F2");
            TotalOdds = _betslip.TotalOdds.ToString("F4");
            EventCount = _betslip.EventCount.ToString();
            Status = _betslip.Status.ToString();
            Events = _betslip.Events.Select(e => new EventXML(e)).ToList<EventXML>();
        }
    }



    public class BetslipTableInfo
    {
        public string ID { get; set; }
        public string Provider { get; set; }
        public string Date { get; set; }
        public string EventCount { get; set; }
        public string Wager { get; set; }
        public string Payout { get; set; }
        public string TotalOdds { get; set; }
        public string Status { get; set; }

        public BetslipTableInfo(Betslip _betslip)
        {
            ID = _betslip.ID;
            Provider = _betslip.Provider;
            Date = _betslip.Date.ToString(CommonConstants.DATE_FORMAT);
            EventCount = _betslip.EventCount.ToString();
            Wager = _betslip.Wager.ToString("F2");
            Payout = _betslip.Payout.ToString("F2");
            TotalOdds = _betslip.TotalOdds.ToString("F4");
            Status = _betslip.Status.ToString();
        }
    }
}
