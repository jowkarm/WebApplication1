using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 10,
                    FirstName = "William",
                    LastName = "Taylor",
                    Email = "william.taylor@example.com",
                    PhoneNumber = "333-444-5555"
                },
                new Student
                {
                    Id = 11,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890"
                },
                new Student
                {
                    Id = 21,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "987-654-3210"
                },
                new Student
                {
                    Id = 13,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    PhoneNumber = "555-123-4567"
                },
                new Student
                {
                    Id = 41,
                    FirstName = "Bob",
                    LastName = "Williams",
                    Email = "bob.williams@example.com",
                    PhoneNumber = "444-789-0123"
                },
                new Student
                {
                    Id = 15,
                    FirstName = "Eva",
                    LastName = "Brown",
                    Email = "eva.brown@example.com",
                    PhoneNumber = "789-012-3456"
                },
                new Student
                {
                    Id = 61,
                    FirstName = "Michael",
                    LastName = "Lee",
                    Email = "michael.lee@example.com",
                    PhoneNumber = "111-222-3333"
                },
                new Student
                {
                    Id = 17,
                    FirstName = "Olivia",
                    LastName = "Miller",
                    Email = "olivia.miller@example.com",
                    PhoneNumber = "777-888-9999"
                },
                new Student
                {
                    Id = 18,
                    FirstName = "Daniel",
                    LastName = "Davis",
                    Email = "daniel.davis@example.com",
                    PhoneNumber = "222-333-4444"
                },
                new Student
                {
                    Id = 19,
                    FirstName = "Sophia",
                    LastName = "Moore",
                    Email = "sophia.moore@example.com",
                    PhoneNumber = "666-777-8888"
                }
            );

            modelBuilder.Entity<CaseNote>().HasData(
                new CaseNote
                {
                    Id = 1,
                    StudentId = 10,
                    Status = true,
                    Subject = "Subject 1",
                    Note = "Note 1",
                    DueDate = DateTime.Now.AddDays(5),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 2,
                    StudentId = 11,
                    Status = false,
                    Subject = "Subject 2",
                    Note = "Note 2",
                    DueDate = DateTime.Now.AddDays(8),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 3,
                    StudentId = 13,
                    Status = true,
                    Subject = "Subject 3",
                    Note = "Note 3",
                    DueDate = DateTime.Now.AddDays(3),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 4,
                    StudentId = 21,
                    Status = false,
                    Subject = "Subject 4",
                    Note = "Note 4",
                    DueDate = DateTime.Now.AddDays(10),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 5,
                    StudentId = 41,
                    Status = true,
                    Subject = "Subject 5",
                    Note = "Note 5",
                    DueDate = DateTime.Now.AddDays(7),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 6,
                    StudentId = 10,
                    Status = false,
                    Subject = "Subject 6",
                    Note = "Note 6",
                    DueDate = DateTime.Now.AddDays(2),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 7,
                    StudentId = 11,
                    Status = true,
                    Subject = "Subject 7",
                    Note = "Note 7",
                    DueDate = DateTime.Now.AddDays(6),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 8,
                    StudentId = 13,
                    Status = false,
                    Subject = "Subject 8",
                    Note = "Note 8",
                    DueDate = DateTime.Now.AddDays(9),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 9,
                    StudentId = 21,
                    Status = true,
                    Subject = "Subject 9",
                    Note = "Note 9",
                    DueDate = DateTime.Now.AddDays(4),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 10,
                    StudentId = 41,
                    Status = false,
                    Subject = "Subject 10",
                    Note = "Note 10",
                    DueDate = DateTime.Now.AddDays(12),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 11,
                    StudentId = 10,
                    Status = true,
                    Subject = "Subject 11",
                    Note = "Note 11",
                    DueDate = DateTime.Now.AddDays(1),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 12,
                    StudentId = 11,
                    Status = false,
                    Subject = "Subject 12",
                    Note = "Note 12",
                    DueDate = DateTime.Now.AddDays(11),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 13,
                    StudentId = 13,
                    Status = true,
                    Subject = "Subject 13",
                    Note = "Note 13",
                    DueDate = DateTime.Now.AddDays(14),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 14,
                    StudentId = 21,
                    Status = false,
                    Subject = "Subject 14",
                    Note = "Note 14",
                    DueDate = DateTime.Now.AddDays(13),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 15,
                    StudentId = 41,
                    Status = true,
                    Subject = "Subject 15",
                    Note = "Note 15",
                    DueDate = DateTime.Now.AddDays(15),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 16,
                    StudentId = 10,
                    Status = false,
                    Subject = "Subject 16",
                    Note = "Note 16",
                    DueDate = DateTime.Now.AddDays(17),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 17,
                    StudentId = 11,
                    Status = true,
                    Subject = "Subject 17",
                    Note = "Note 17",
                    DueDate = DateTime.Now.AddDays(20),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 18,
                    StudentId = 13,
                    Status = false,
                    Subject = "Subject 18",
                    Note = "Note 18",
                    DueDate = DateTime.Now.AddDays(19),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 19,
                    StudentId = 21,
                    Status = true,
                    Subject = "Subject 19",
                    Note = "Note 19",
                    DueDate = DateTime.Now.AddDays(22),
                    OpenDate = DateTime.Now
                },
                new CaseNote
                {
                    Id = 20,
                    StudentId = 41,
                    Status = false,
                    Subject = "Subject 20",
                    Note = "Note 20",
                    DueDate = DateTime.Now.AddDays(21),
                    OpenDate = DateTime.Now
                }
            );

        }
    }
}
