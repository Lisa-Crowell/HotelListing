namespace HotelListing.API.QueryParameters;

public class QueryParameters
{
    private int _pageSize = 15;
    public int StartIndex { get; set; } = 0;
    public int PageNumber { get; set; } = 1;
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > 100) ? 100 : value;
    }
}


