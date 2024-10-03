using System;
using System.Collections.Generic;
using System.Linq;



namespace BettingRecordApp
{
    public static class UtilityFilter
    {
        // --- Event filtering ---

        public static List<Event> FilterEventsBySport(List<Event> _eventList, string _sport)
        {
            return (_eventList.Where(e => (e.SportInfo.Sport == _sport)).ToList<Event>());
        }

        public static List<Event> FilterEventsByLeague(List<Event> _eventList, string _sport, string _league)
        {
            return (_eventList.Where(e => (e.SportInfo.Sport == _sport && e.SportInfo.League == _league)).ToList<Event>());
        }

        public static List<Event> FilterEventsByLeague(List<Event> _eventList, string _league)
        {
            return (_eventList.Where(e => (e.SportInfo.League == _league)).ToList<Event>());
        }



        // --- Betslip filtering ---

        public static List<Betslip> FilterBetslipsByProvider(List<Betslip> _betslipList, string _provider)
        {
            return (_betslipList.Where(b => (b.Provider == _provider)).ToList<Betslip>());
        }

        public static List<Betslip> FilterBetslipsByYear(List<Betslip> _betslipList, string _year)
        {
            return (FilterBetslipsByYear(_betslipList, Convert.ToInt16(_year)));
        }

        public static List<Betslip> FilterBetslipsByYear(List<Betslip> _betslipList, int _year)
        {
            return (_betslipList.Where(b => (b.Date.Year == _year)).ToList<Betslip>());
        }

        public static List<Betslip> FilterBetslipsByMonth(List<Betslip> _betslipList, string _month)
        {
            return (FilterBetslipsByMonth(_betslipList, Convert.ToInt16(_month)));
        }

        public static List<Betslip> FilterBetslipsByMonth(List<Betslip> _betslipList, int _month)
        {
            return (_betslipList.Where(b => (b.Date.Month == _month)).ToList<Betslip>());
        }

        public static List<Betslip> FilterBetslipsByMonth(List<Betslip> _betslipList, string _year, string _month)
        {
            return (FilterBetslipsByMonth(_betslipList, Convert.ToInt16(_year), Convert.ToInt16(_month)));
        }

        public static List<Betslip> FilterBetslipsByMonth(List<Betslip> _betslipList, int _year, int _month)
        {
            return (_betslipList.Where(b => (b.Date.Year == _year && b.Date.Month == _month)).ToList<Betslip>());
        }
    }
}
