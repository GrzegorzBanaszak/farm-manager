using farm_manager.Domain.Entities;

namespace farm_manager.Application.Interfaces.Persistence
{
    public interface IFieldRepository
    {
        Task<Field?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<List<Field>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(Field field, CancellationToken cancellationToken = default);
        void Remove(Field field);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
