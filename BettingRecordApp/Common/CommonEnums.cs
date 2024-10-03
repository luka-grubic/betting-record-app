namespace BettingRecordApp
{
    public enum FILE_TYPE
    {
        UNKNOWN,
        XML,
        JSON
    }



    public enum OPERATION
    {
        ADD,
        EDIT
    }



    public enum EVENT_STATUS
    {
        ACTIVE = 1,
        WIN = 2,
        LOSS = 3,
        VOID = 4
    }



    public enum BETSLIP_STATUS
    {
        ACTIVE = 1,
        WIN = 2,
        LOSS = 3,
        VOID = 4
    }
}
