using MagicApps.Models;
using ShuaBets.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShuaBets.WebUI.Models.Exclusive
{
    public class ExclusiveListViewModel
    {
        public IEnumerable<ExclusiveTip> ExclusiveTips { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public SearchExclusiveViewModel SearchModel { get; set; }

        public string[] Roles { get; set; }
    }
}