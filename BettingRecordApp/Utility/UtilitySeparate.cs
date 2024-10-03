using System;
using System.Collections.Generic;
using System.Linq;



namespace BettingRecordApp
{
    public static class UtilitySeparate
    {
        // --- Event separating ---

        public static Dictionary<string, List<Event>> SeparateEventsBySport(List<Event> _eventList)
        {
            return (
                _eventList
                    .GroupBy(e => e.SportInfo.Sport)
                    .ToDictionary(e => e.Key, e => e.ToList<Event>())
            );
        }

        public static Dictionary<string, Dictionary<string, List<Event>>> SeparateEventsBySportAndLeague(List<Event> _eventList)
        {
            return (
                _eventList
                    .GroupBy(e => e.SportInfo.Sport)
                    .ToDictionary(
                        group => group.Key,
                        group => group
                            .GroupBy(e => e.SportInfo.League)
                            .ToDictionary(
                                subgroup => subgroup.Key,
                                subgroup => subgroup.ToList<Event>()
                            )
                    )
            );
        }



        // --- Betslip separating ---

        public static Dictionary<DateTime, List<Betslip>> SeparateBetslipsByDate(List<Betslip> _betslipList)
        {
            return (
                _betslipList
                    .GroupBy(b => b.Date)
                    .ToDictionary(b => b.Key, b => b.ToList<Betslip>())
            );
        }
    }
}
