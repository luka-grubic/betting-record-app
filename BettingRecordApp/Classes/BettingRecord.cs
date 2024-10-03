using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;



namespace BettingRecordApp
{
    public class BettingRecord
    {
        public List<Betslip> Betslips { get; set; }

        public BettingRecord()
        {
            Betslips = new List<Betslip>();
        }

        public BettingRecord(BettingRecordXML _bettingRecordXML)
        {
            Betslips = _bettingRecordXML.Betslips.Select(b => new Betslip(b)).ToList<Betslip>();
        }
    }



    [XmlRoot("BettingRecord")]
    public class BettingRecordXML
    {
        [XmlArray("Betslips")]
        [XmlArrayItem("Betslip")]
        public List<BetslipXML> Betslips { get; set; }

        public BettingRecordXML()
        {
            // NOTHING
        }

        public BettingRecordXML(BettingRecord _bettingRecord)
        {
            Betslips = _bettingRecord.Betslips.Select(b => new BetslipXML(b)).ToList<BetslipXML>();
        }
    }
}
