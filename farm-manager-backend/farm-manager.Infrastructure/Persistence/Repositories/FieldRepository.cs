using farm_manager.Application.Interfaces.Persistence;
using farm_manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace farm_manager.Infrastructure.Persistence.Repositories
{
    public class FieldRepository : IFieldRepository
    {
        private readonly AppDbContext _context;

        public FieldRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Field>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Fields.ToListAsync(cancellationToken);
        }
        public async Task<Field?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Fields
                .Include(f => f.Crops)
                .FirstOrDefaultAsync(f => f.Id == id, cancellationToken);
        }
        public async Task AddAsync(Field field, CancellationToken cancellationToken = default)
        {
            await _context.Fields.AddAsync(field, cancellationToken);
        }

        public void Remove(Field field)
        {
            _context.Fields.Remove(field);
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
