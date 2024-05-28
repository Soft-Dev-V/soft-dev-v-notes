public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
  public StudentRepository(BaseContext context) : base(context)
  {
    
  }

  public Task<IList<Career>> GetCareers(Guid idStudent)
  {
    throw new NotImplementedException();
  }
}
