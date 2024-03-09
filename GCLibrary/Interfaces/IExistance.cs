namespace GCLibrary.Interfaces
{
    public interface IExistance
    {
        bool IsExists<ModelType>(ModelType modelType);
    }
}