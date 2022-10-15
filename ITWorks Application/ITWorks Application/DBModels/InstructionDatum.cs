using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class InstructionDatum
    {
        public int InstructionId { get; set; }
        public string InstructionTitle { get; set; }
        public string InstructionContent { get; set; }
    }
}
