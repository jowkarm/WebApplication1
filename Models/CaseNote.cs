using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class CaseNote
    {
        
        
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public DateTime OpenDate { get; set; }
        public DateTime DueDate { get; set; }
        
        public int StudentId { get; set; }

        [JsonIgnore]
        public virtual Student? Student { get; set; }

        public CaseNote()
        {
            
        }

        public CaseNote(int id, int studentId, bool status, string subject, string note, DateTime dueDate)
        {
            Id = id;
            StudentId = studentId;
            Status = status;
            Subject = subject;
            Note = note;
            DueDate = dueDate;
            OpenDate = DateTime.Now;
        }

        
    }
}
