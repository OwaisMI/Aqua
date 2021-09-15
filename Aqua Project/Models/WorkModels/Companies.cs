using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Aqua_Project.Models.WorkModels
{
    public partial class Companies
    {
        public Companies()
        {
            BusinessActivtiy = new HashSet<BusinessActivtiy>();
            Socials = new HashSet<Socials>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int Number { get; set; }
        public string Branch { get; set; }
        public string Email { get; set; }

        public virtual ICollection<BusinessActivtiy> BusinessActivtiy { get; set; }
        public virtual ICollection<Socials> Socials { get; set; }
    }
}
