using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public int CtcLinkId { get; set; }

    public string? ClothingSize { get; set; }

    public string? TribeName { get; set; }

    public virtual ICollection<Case> Cases { get; set; } = new List<Case>();

    public virtual ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();

    public virtual Student CtcLink { get; set; } = null!;
}
