using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CheckIn
{
    public int Id { get; set; }

    public int? Physical { get; set; }

    public int? Spritual { get; set; }

    public int? Mental { get; set; }

    public int? Emotional { get; set; }

    public int? Academic { get; set; }

    public int? Social { get; set; }

    public int? Financial { get; set; }

    public string? Notes { get; set; }

    public bool? FollowUp { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public int ProfileId { get; set; }

    public virtual Profile Profile { get; set; } = null!;
}
