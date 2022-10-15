using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class AccountDatum
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public int AccountTypeId { get; set; }
    }
}
