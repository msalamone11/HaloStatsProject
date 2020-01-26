using System;
using System.Threading.Tasks;
using HaloEzAPI;
using HaloEzAPI.Model.Response.MetaData.Halo5;
using HaloEzAPI.Model.Response.Stats.Halo5.Arena;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HaloStatsProject.Pages
{
    public class MatchDetailsModel : PageModel
    {
        public ArenaPostGameReport PlayerStats;
        public string MatchId;

        public GameVariant GameTypeName;

        public async Task OnGetAsync(string matchId)
        {
            MatchId = matchId;

            var haloApiService = new HaloAPIService("bdd5cbaf0ca34682a8f6b50742747e6f", "https://www.haloapi.com");

            PlayerStats = await haloApiService.GetArenaPostGameCarnageReport(Guid.Parse(matchId));

            GameTypeName = await haloApiService.GetGameVariant(PlayerStats.GameVariantResourceId.ResourceId.ToString());
        }
    }
}
