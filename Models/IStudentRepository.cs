namespace TrinhHoangTung.Models
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }  
    }
}
