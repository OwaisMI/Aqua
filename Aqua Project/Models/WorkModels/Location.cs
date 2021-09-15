using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Aqua_Project.Models.WorkModels
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public string CityName { get; set; }
        public string POBox { get; set; }
        public string StreetNumber { get; set; }
        public int? ZipCode { get; set; }
    }
}
