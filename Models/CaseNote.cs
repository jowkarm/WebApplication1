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
        public virtual Student Student { get; set; }

        public CaseNote(bool status, string subject, string note, DateTime dueDate)
        {
            this.Status = status;
            this.Subject = subject;
            this.Note = note;
            this.DueDate = dueDate;
            this.OpenDate = DateTime.Now;
        }

        
    }
}
