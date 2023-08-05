using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCRUDApp.Data
{
    public partial class TblEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public int GrossSalary { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
        public int NationalityId { get; set; }
        public int BranchId { get; set; }
    }
}
