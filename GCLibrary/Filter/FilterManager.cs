using GCLibrary.Logger;
using System.Threading.Channels;

namespace GCLibrary.Filter
{

    public class FilterManager : ILogConsumer
    {

        private IGCLogger _logger = new ConsoleLogger();

        public IGCLogger Logger { get { return _logger; } set { _logger = value; } }


        private List<IFilter> _filters = [];
        public FilterManager()
        {
            _logger.Info("Filter Manager is running");
            Console.WriteLine();

        }

        public FilterManager Add(IFilter filter)
        {
            int count = _filters.Count + 1;
            _logger.Info($"Adding Filter {count}");
            _filters.Add(filter);
            return this;
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

        public Response Filter()
        {
            Console.WriteLine();
            if (_filters.Count != 0)
            {
                int count = 0;
                foreach (IFilter filter in _filters)
                {
                    count++;
                    _logger.Info($" running Filter {count}");
                    Response response = filter.RunFilter();

                    if (!response.Success) return response;
                }
            }

            Response result = Response.ResponseBuilder.SetSuccess("All filter run successfull");
            return result;
        }
    }
}