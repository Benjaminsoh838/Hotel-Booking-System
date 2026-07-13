using System.ComponentModel.DataAnnotations;

namespace Demo.Models;

#nullable disable warnings

// View Models ----------------------------------------------------------------

public class TeacherVM
{
    public string? Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; }
}

public class SubjectVM
{
    public string? Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; }
}
