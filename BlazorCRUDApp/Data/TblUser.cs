using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCRUDApp.Data
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Passwordexp { get; set; }
        public string Role { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
    }
}
