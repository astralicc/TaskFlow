using System;
using System.Collections.Generic;

namespace TaskFlow.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly DueDate { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
