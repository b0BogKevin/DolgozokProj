using System;
using System.Collections.Generic;

namespace Dolgozok.Models;

public partial class Worker
{
    public string Name { get; set; }

    public string Email { get; set; }

    public int Salary { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Email}) - {Salary} Ft";
    }
}
