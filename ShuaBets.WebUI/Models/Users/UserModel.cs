using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShuaBets.Domain.Entities;

namespace ShuaBets.WebUI.Models.Users
{
    public class UserModel
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}