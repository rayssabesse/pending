using System;
using System.Collections.Generic;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class BAddress
    {
        public short IdUser { get; set; }
        public short IdBAddress { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual Business Business { get; set; }
    }
}
