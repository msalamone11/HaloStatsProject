using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HaloEzAPI;
using HaloEzAPI.Model.Response.Stats.Halo5.Arena;
using HaloStatsProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HaloStatsProject.Pages
{
    public class MatchDetailsModel : PageModel
    {
        public ArenaPostGameReport PlayerStats;
        public string MatchId;

        public async Task OnGetAsync(string matchId)
        {
            MatchId = matchId;

            var haloApiService = new HaloAPIService("bdd5cbaf0ca34682a8f6b50742747e6f", "https://www.haloapi.com");

            PlayerStats = await haloApiService.GetArenaPostGameCarnageReport(Guid.Parse(matchId));
        }
    }
}
