using System;
using System.Collections.Generic;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class CAccount
    {
        public short IdClient { get; set; }
        public short IdSituation { get; set; }
        public short IdCAccount { get; set; }
        public string Balance { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Situation IdSituationNavigation { get; set; }
    }
}
