using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase, new()
{
  protected readonly BaseContext _context;

  protected BaseRepository(BaseContext context)
  {
    _context = context;
  }

  public async Task<int> Create(T entity)
  {
    _context.Set<T>().Add(entity);
    return await _context.SaveChangesAsync();
  }

  public Task<int> Delete(T entity)
  {
    throw new NotImplementedException();
  }

  public void Dispose()
  {
    _context.Dispose();
  }

  public async Task<T> GetById(Guid id)
  {
    return await _context.Set<T>().FirstAsync(entity => entity.Id.Equals(id));
  }

  public async Task<IList<T>> Read(Expression<Func<T, bool>> lambda)
  {
    lambda.Compile();
    return await _context.Set<T>().Where(lambda).ToListAsync();
  }

  public Task<int> Update(T entity)
  {
    throw new NotImplementedException();
  }
}
