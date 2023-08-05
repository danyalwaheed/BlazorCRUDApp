using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCRUDApp.Data
{
    public partial class TblCountry
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int RegionId { get; set; }
    }
}
