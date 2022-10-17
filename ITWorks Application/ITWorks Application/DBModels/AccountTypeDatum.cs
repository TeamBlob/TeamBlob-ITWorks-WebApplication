using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    [Keyless]
    public partial class AccountTypeDatum
    {
        [Column("TypeID")]
        public int TypeId { get; set; }
        [Required]
        [StringLength(10)]
        public string TypeName { get; set; }
    }
}
