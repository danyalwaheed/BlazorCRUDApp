using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCRUDApp.Data
{
    public partial class TblBranch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public int CompanyId { get; set; }
        public int CountryId { get; set; }
    }
}
