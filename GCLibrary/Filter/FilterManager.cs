namespace GCLibrary.Filter
{


    public class FilterManager
    {
        private List<IFilter> _filters = [];
        public void Add(IFilter filter)
        {
            _filters.Add(filter);
        }

        public bool Remove(IFilter filter)
        {
            if (_filters.Contains(filter))
            {
                _filters.Remove(filter);
                return true;
            }
            return false;
        }

        public List<IFilter> GetAll()
        {
            return _filters.ToList();
        }

        public IFilter? Get(int index)
        {
            if (_filters.Count == 0) return null;
            if (index >= 0 && index < _filters.Count)
                return _filters[index];
            return null;
        }

        public Response Use()
        {
            if (_filters.Count != 0)
            {
                foreach (IFilter filter in _filters)
                {

                    Response response = filter.RunFilter();

                    if (!response.Success) return response;
                }
            }

            Response result = Response.ResponseBuilder.SetSuccess("All filter run successfull");
            return result;
        }
    }
}