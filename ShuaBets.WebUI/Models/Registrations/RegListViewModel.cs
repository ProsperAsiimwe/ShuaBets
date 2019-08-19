using MagicApps.Models;
using ShuaBets.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShuaBets.WebUI.Models.Registrations
{
    public class RegListViewModel
    {

        public IEnumerable<Registration> Registrations { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public SearchRegViewModel SearchModel { get; set; }

        public string[] Roles { get; set; }

    }
}