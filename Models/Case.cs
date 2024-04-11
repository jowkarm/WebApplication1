using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Case
{
    public int CaseId { get; set; }

    public bool Closed { get; set; }

    public string Subject { get; set; } = null!;

    public string? ActionTaken { get; set; }

    public DateTime DateOpened { get; set; }

    public DateTime? DateClosed { get; set; }

    public DateTime? DueDate { get; set; }

    public bool? FollowUp { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public int? Priority { get; set; }

    public int ProfileId { get; set; }

    public virtual Profile Profile { get; set; } = null!;
}
