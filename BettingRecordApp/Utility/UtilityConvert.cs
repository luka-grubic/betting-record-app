using System;
using System.Collections.Generic;
using System.Linq;



namespace BettingRecordApp
{
    public static class UtilityConvert
    {
        public static List<string> ConvertEnumToStringList(System.Type _type)
        {
            return (Enum.GetNames(_type).ToList<string>());
        }



        public static List<BetslipTableInfo> GetBetslipTableInfoList(List<Betslip> _betslipList)
        {
            return (_betslipList.Select(b => new BetslipTableInfo(b)).ToList<BetslipTableInfo>());
        }



        public static List<EventTableInfo> GetEventTableInfoList(List<Event> _eventList)
        {
            return (_eventList.Select(e => new EventTableInfo(e)).ToList<EventTableInfo>());
        }



        public static BETSLIP_STATUS ConvertEventStatusToBetslipStatus(EVENT_STATUS _eventStatus)
        {
            return ((BETSLIP_STATUS)_eventStatus);
        }
    }
}
