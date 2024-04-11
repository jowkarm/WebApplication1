using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int CtcLinkId { get; set; }

    public virtual Profile? Profile { get; set; }
}
