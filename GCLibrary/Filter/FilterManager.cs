using GCLibrary.Filter;


namespace GCLibrary.Filter
{

}
public class FilterManager
{
    private static List<IFilter> _filters = [];
    public static void Add( IFilter filter)
    {
        _filters.Add(filter);
    }

    public static bool Remove(IFilter filter)
    {
        if (_filters.Contains(filter))
        {
            _filters.Remove(filter);
            return true;
        }
        return false;
    }

    public static List<IFilter> GetAll()
    {
        return _filters.ToList();
    }

    public static IFilter? Get(int index)
    {
        if( _filters.Count == 0 ) return null;
        if ( index >= 0 && index <_filters.Count)
            return _filters[index];
        return null;
    }

    public static FilterResponse Use()
    {
        foreach (IFilter filter in _filters)
        {
            filter.RunFilter();
            if (!filter.Result.Success) return filter.Result;
        }
        FilterResponse result = new();
        result.Success = true;
        result.Message = "All filter run successfull";
        result.Error = "";
        return result;
    }
}