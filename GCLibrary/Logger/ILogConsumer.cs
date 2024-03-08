

namespace GCLibrary.Logger
{
    public interface ILogConsumer
    {
        IGCLogger Logger { get; set; }

    }
}