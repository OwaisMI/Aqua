using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Aqua_Project.Models.WorkModels
{
    public partial class License
    {
       
        public int LicenseId { get; set; }
        public int LicenseNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Url { get; set; }
    }
}
