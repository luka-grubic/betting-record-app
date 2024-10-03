using System;
using System.Xml.Serialization;



namespace BettingRecordApp
{
    public class BetInfo
    {
        public string BetCategory { get; set; }
        public string Bet { get; set; }
        public bool IsMultibet { get; set; }
        public bool IsLive { get; set; }
        public decimal Odds { get; set; }

        public BetInfo()
        {
            // NOTHING
        }

        public BetInfo(BetInfoXML _betInfoXML)
        {
            BetCategory = _betInfoXML.BetCategory;
            Bet = _betInfoXML.Bet;
            IsMultibet = UtilityCommon.StringToBool(_betInfoXML.IsMultibet);
            IsLive = UtilityCommon.StringToBool(_betInfoXML.IsLive);
            Odds = Convert.ToDecimal(_betInfoXML.Odds);
        }
    }



    public class BetInfoXML
    {
        [XmlAttribute("BetCategory")]
        public string BetCategory { get; set; }
        [XmlAttribute("Bet")]
        public string Bet { get; set; }
        [XmlAttribute("IsMultibet")]
        public string IsMultibet { get; set; }
        [XmlAttribute("IsLive")]
        public string IsLive { get; set; }
        [XmlAttribute("Odds")]
        public string Odds { get; set; }

        public BetInfoXML()
        {
            // NOTHING
        }

        public BetInfoXML(BetInfo _betInfo)
        {
            BetCategory = _betInfo.BetCategory;
            Bet = _betInfo.Bet;
            IsMultibet = UtilityCommon.BoolToString(_betInfo.IsMultibet);
            IsLive = UtilityCommon.BoolToString(_betInfo.IsLive);
            Odds = _betInfo.Odds.ToString("F2");
        }
    }
}
