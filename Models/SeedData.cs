using Microsoft.EntityFrameworkCore;

namespace TrinhHoangTung.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Students.Any())
            {
                context.Students.AddRange(
                        new Student
                        {
                            MSSV = "4601104001",
                            FirstName = "Nguyen van",
                            LastName = "A",
                            Birthday = "1/1/2002",
                            Gender = true,
                            Address="281 ADV",
                            DateCreate= DateTime.Now
                        },
                        new Student
                        {
                            MSSV = "4601104002",
                            FirstName = "Nguyen Van",
                            LastName = "B",
                            Birthday = "1/1/2002",
                            Gender = true,
                            Address = "281 ADV",
                            DateCreate = DateTime.Now
                        }, 
                        new Student
                        {
                            MSSV = "4601104001",
                            FirstName = "Nguyen van",
                            LastName = "C",
                            Birthday = "1/1/2002",
                            Gender = true,
                            Address = "281 ADV",
                            DateCreate = DateTime.Now
                        },
                        new Student
                        {
                            MSSV = "4601104001",
                            FirstName = "nguen van ",
                            LastName = "D",
                            Birthday = "1/1/2002",
                            Gender = true,
                            Address = "281 ADV",
                            DateCreate = DateTime.Now
                        },
                        new Student
                        {
                            MSSV = "4601104001",
                            FirstName = "tran van",
                            LastName = "E",
                            Birthday = "1/1/2002",
                            Gender = true,
                            Address = "281 ADV",
                            DateCreate = DateTime.Now
                        },
                        new Student
                        {
                            MSSV = "4601104001",
                            FirstName = "John",
                            LastName = "Cenna",
                            Birthday = "1/1/2002",
                            Gender = true,
                            Address = "281 ADV",
                            DateCreate = DateTime.Now
                        },
                        new Student
                        {
                            MSSV = "4601104001",
                            FirstName = "Hoang",
                            LastName = "Tung",
                            Birthday = "1/1/2002",
                            Gender = true,
                            Address = "281 ADV",
                            DateCreate = DateTime.Now
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
