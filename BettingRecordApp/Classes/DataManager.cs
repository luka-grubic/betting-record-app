namespace BettingRecordApp
{
    public static class DataManager
    {
        public static BettingRecord BettingRecord { get; set; }
        public static Recommendations Recommendations { get; set; }

        public static void Init()
        {
            BettingRecord = new BettingRecord();
            Recommendations = new Recommendations();
        }

        public static void Init(BettingRecord _bettingRecord)
        {
            Init();

            if (_bettingRecord != null)
            {
                BettingRecord = _bettingRecord;
                Recommendations.LoadBettingRecordRecommendations(_bettingRecord);
            }
        }

        public static void AddBetslip(Betslip _betslip)
        {
            BettingRecord.Betslips.Add(_betslip);
            UtilitySorting.SortBetslipListByDate(BettingRecord.Betslips);

            Recommendations.Update(_betslip);
        }

        public static void EditBetslip(int _betslipIndex, Betslip _betslip)
        {
            BettingRecord.Betslips[_betslipIndex] = _betslip;
            UtilitySorting.SortBetslipListByDate(BettingRecord.Betslips);

            Recommendations.Update(_betslip);
        }

        public static void RemoveBetslip(int _betslipIndex)
        {
            BettingRecord.Betslips.RemoveAt(_betslipIndex);
        }

        public static void AddEvent(int _betslipIndex, Event _event)
        {
            BettingRecord.Betslips[_betslipIndex].Events.Add(_event);
            UtilitySorting.SortEventListByDateTime(BettingRecord.Betslips[_betslipIndex].Events);

            Recommendations.Update(_event);
        }

        public static void EditEvent(int _betslipIndex, int _eventIndex, Event _event)
        {
            BettingRecord.Betslips[_betslipIndex].Events[_eventIndex] = _event;
            UtilitySorting.SortEventListByDateTime(BettingRecord.Betslips[_betslipIndex].Events);

            Recommendations.Update(_event);
        }

        public static void RemoveEvent(int _betslipIndex, int _eventIndex)
        {
            BettingRecord.Betslips[_betslipIndex].Events.RemoveAt(_eventIndex);
        }
    }
}
