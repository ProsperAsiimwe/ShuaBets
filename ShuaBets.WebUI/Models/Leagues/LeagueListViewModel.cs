using MagicApps.Models;
using ShuaBets.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShuaBets.WebUI.Models.Leagues
{
    public class LeagueListViewModel
    {
        public IEnumerable<League> Leagues { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public SearchLeagueViewModel SearchModel { get; set; }

        public string[] Roles { get; set; }
    }
}