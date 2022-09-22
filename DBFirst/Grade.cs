using System;
using System.Collections.Generic;

namespace DBFirst
{
    public partial class Grade
    {
        public string Grade1 { get; set; } = null!;
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }
    }
}
