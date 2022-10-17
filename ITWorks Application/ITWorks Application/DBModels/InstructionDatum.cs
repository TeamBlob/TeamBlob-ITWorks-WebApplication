using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class InstructionDatum
    {
        [Key]
        [Column("InstructionID")]
        public int InstructionId { get; set; }
        [Required]
        [StringLength(50)]
        public string InstructionTitle { get; set; }
        [Required]
        [StringLength(200)]
        public string InstructionContent { get; set; }
    }
}
