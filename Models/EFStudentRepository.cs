namespace TrinhHoangTung.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFStudentRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public IQueryable<Student> Students => _ctx.Students; 
    }
}
