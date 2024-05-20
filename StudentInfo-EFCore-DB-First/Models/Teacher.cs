using System;
using System.Collections.Generic;

namespace StudentInfo_EFCore_DB_First.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal Salary { get; set; }
}
