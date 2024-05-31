using Microsoft.EntityFrameworkCore;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
  public StudentRepository(BaseContext context) : base(context)
  {
    
  }

  public async Task<IList<Career>> GetCareers(Guid idStudent)
  {
    var response = await _context.Set<Student>()
                          // .IgnoreAutoIncludes()
                          .Include(s => s.Careers)
                          .FirstAsync(p => p.Id.Equals(idStudent));
                          
    return response.Careers;
  }
}
