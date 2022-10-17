using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    [Keyless]
    public partial class AccountTypeAssignmentDatum
    {
        [Column("TypeID")]
        public int TypeId { get; set; }
        [Column("AccountID")]
        public int AccountId { get; set; }
    }
}
