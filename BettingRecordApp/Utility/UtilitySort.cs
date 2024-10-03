using System.Collections.Generic;



namespace BettingRecordApp
{
    public static class UtilitySort
    {
        // --- Event sorting ---

        public static void SortEventListByDateTime(List<Event> _eventList)
        {
            _eventList.Sort((e1, e2) => e1.EventInfo.DateTime.CompareTo(e2.EventInfo.DateTime));
        }



        // --- Betslip sorting

        public static void SortBetslipListByDate(List<Betslip> _betslipList)
        {
            _betslipList.Sort((b1, b2) => b1.Date.CompareTo(b2.Date));
        }
    }
}
