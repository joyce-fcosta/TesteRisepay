using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces
{
    public interface ICargo : IGenerics<Cargo>
    {
        Task<Cargo> BuscarCargoAsync(int id);
    }
}
