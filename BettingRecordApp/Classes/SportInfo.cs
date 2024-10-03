using System.Xml.Serialization;



namespace BettingRecordApp
{
    public class SportInfo
    {
        public string Sport { get; set; }
        public string League { get; set; }

        public SportInfo()
        {
            // NOTHING
        }

        public SportInfo(SportInfoXML _sportInfoXML)
        {
            Sport = _sportInfoXML.Sport;
            League = _sportInfoXML.League;
        }
    }



    public class SportInfoXML
    {
        [XmlAttribute("Sport")]
        public string Sport { get; set; }
        [XmlAttribute("League")]
        public string League { get; set; }

        public SportInfoXML()
        {
            // NOTHING
        }

        public SportInfoXML(SportInfo _sportInfo)
        {
            Sport = _sportInfo.Sport;
            League = _sportInfo.League;
        }
    }
}
