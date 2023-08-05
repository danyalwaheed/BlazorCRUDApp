using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCRUDApp.Data
{
    public partial class TblEmployeeDocument
    {
        public int EmployeeDocumentId { get; set; }
        public string DocumentPath { get; set; }
        public string Remarks { get; set; }
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public int DocumentCategoryId { get; set; }
    }
}
