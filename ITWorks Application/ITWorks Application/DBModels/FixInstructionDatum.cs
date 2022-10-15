using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class FixInstructionDatum
    {
        public int? FixId { get; set; }
        public int? InstructionId { get; set; }
        public int? SolutionStep { get; set; }
    }
}
