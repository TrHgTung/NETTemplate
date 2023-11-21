using System.ComponentModel.DataAnnotations.Schema;
namespace TrinhHoangTung.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string MSSV { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;
        public bool Gender { get; set; }   
        public string Address { get; set; } = string.Empty;
        public DateTime DateCreate { get; set; }
    }
}
