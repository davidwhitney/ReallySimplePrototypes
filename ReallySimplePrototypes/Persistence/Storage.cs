namespace ReallySimplePrototypes.Persistence
{
    public interface IStorage
    {
        TType GetOrEmpty<TType>(object id) where TType : ICanBeSaved, new();
        TType Get<TType>(object id) where TType : ICanBeSaved, new();
        TType Load<TType>(object id) where TType : ICanBeSaved;
        TType Save<TType>(TType item) where TType : ICanBeSaved;
    }
}