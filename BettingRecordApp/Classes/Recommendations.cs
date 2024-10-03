using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BettingRecordApp
{
    public class Recommendations
    {
        public SortedSet<string> Providers { get; set; }
        public SortedSet<string> Sports { get; set; }
        public Dictionary<string, SortedSet<string>> LeaguesPerSport { get; set; }
        public Dictionary<string, SortedSet<string>> BetCategoriesPerSport { get; set; }

        public Recommendations()
        {
            Clear();
        }

        public void Clear()
        {
            Providers = new SortedSet<string>();
            Sports = new SortedSet<string>();
            LeaguesPerSport = new Dictionary<string, SortedSet<string>>();
            BetCategoriesPerSport = new Dictionary<string, SortedSet<string>>();
        }

        public void AddProvider(string _provider)
        {
            Providers.Add(_provider);
        }

        public void AddSport(string _sport)
        {
            Sports.Add(_sport);

            if (!LeaguesPerSport.ContainsKey(_sport))
            {
                LeaguesPerSport.Add(_sport, new SortedSet<string>());
            }

            if (!BetCategoriesPerSport.ContainsKey(_sport))
            {
                BetCategoriesPerSport.Add(_sport, new SortedSet<string>());
            }
        }

        public void AddLeague(string _sport, string _league)
        {
            AddSport(_sport);
            LeaguesPerSport[_sport].Add(_league);
        }

        public void AddBetCategory(string _sport, string _betCategory)
        {
            AddSport(_sport);
            BetCategoriesPerSport[_sport].Add(_betCategory);
        }

        public void Update(Betslip _betslip)
        {
            AddProvider(_betslip.Provider);

            foreach (Event e in _betslip.Events)
            {
                Update(e);
            }
        }

        public void Update(Event _event)
        {
            AddLeague(_event.SportInfo.League, _event.SportInfo.Sport);
            AddBetCategory(_event.BetInfo.BetCategory, _event.SportInfo.Sport);
        }

        public void LoadBettingRecordRecommendations(BettingRecord _bettingRecord)
        {
            Clear();

            if (_bettingRecord != null)
            {
                foreach (Betslip betslip in _bettingRecord.Betslips)
                {
                    Update(betslip);
                }
            }
        }

        public List<string> GetProviderList()
        {
            return (Providers.ToList<string>());
        }

        public List<string> GetSportList()
        {
            return (Sports.ToList<string>());
        }

        public List<string> GetLeagueList(string _sport)
        {
            List<string> tempList = new List<string>();

            if (LeaguesPerSport.ContainsKey(_sport))
            {
                tempList = LeaguesPerSport[_sport].ToList<string>();
            }

            return tempList;
        }

        public List<string> GetBetCategoryList(string _sport)
        {
            List<string> tempList = new List<string>();

            if (BetCategoriesPerSport.ContainsKey(_sport))
            {
                tempList = BetCategoriesPerSport[_sport].ToList<string>();
            }

            return tempList;
        }
    }
}
