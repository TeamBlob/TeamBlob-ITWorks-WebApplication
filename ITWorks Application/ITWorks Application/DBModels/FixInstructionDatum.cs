using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    [Keyless]
    public partial class FixInstructionDatum
    {
        [Column("FixID")]
        public int? FixId { get; set; }
        [Column("InstructionID")]
        public int? InstructionId { get; set; }
        public int? SolutionStep { get; set; }
    }
}
