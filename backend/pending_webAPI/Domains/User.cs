using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class User
    {
        public short IdUser { get; set; }

       //[Required(ErrorMessage = "The email field is required")]
        public string EmailUser { get; set; }

       // [Required(ErrorMessage = "The password field is required")]
       //[StringLength(500, MinimumLength = 3, ErrorMessage = "Password must be at least 3 characters long")]
        public string PasswordUser { get; set; }

        public virtual BAddress BAddress { get; set; }
        public virtual Business Business { get; set; }
    }
}
