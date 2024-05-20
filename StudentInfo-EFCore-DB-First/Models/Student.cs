using System;
using System.Collections.Generic;

namespace StudentInfo_EFCore_DB_First.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Roll { get; set; }

    public string Email { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int Age { get; set; }
}
