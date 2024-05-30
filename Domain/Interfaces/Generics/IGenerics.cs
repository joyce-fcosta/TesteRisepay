namespace Domain.Interfaces.Generics
{
    public interface IGenerics<T> where T : class
    {
        Task AddAsync(T objeto);
        Task UppdateAsync(T objeto);
        Task DeleteAsync(T objeto);
        Task<List<T>> ListAsync();
    }
}
