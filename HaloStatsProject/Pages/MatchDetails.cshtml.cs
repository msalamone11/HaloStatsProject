using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HaloEzAPI;
using HaloEzAPI.Abstraction.Enum.Halo5;
using HaloEzAPI.Model.Response.MetaData.Halo5;
using HaloEzAPI.Model.Response.Stats.Halo5;
using HaloEzAPI.Model.Response.Stats.Halo5.Arena;
using HaloStatsProject.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedalAward = HaloStatsProject.Models.MedalAward;

namespace HaloStatsProject.Pages
{
    public class MatchDetailsModel : PageModel
    {
        public ArenaPostGameReport PlayerStats;
        public string MatchId;

        public GameVariant GameTypeName;

        public IEnumerable<Impulse> Impulses { get; set; }

        public IEnumerable<Medal> MedalAwards { get; set; }
        public IEnumerable<Map> Maps { get; private set; }

        public async Task OnGetAsync(string matchId)
        {
            MatchId = matchId;

            var haloApiService = new HaloAPIService("bdd5cbaf0ca34682a8f6b50742747e6f", "https://www.haloapi.com");

            PlayerStats = await haloApiService.GetArenaPostGameCarnageReport(Guid.Parse(matchId));

            GameTypeName = await haloApiService.GetGameVariant(PlayerStats.GameVariantResourceId.ResourceId.ToString());

            Impulses = await haloApiService.GetImpulses();

            MedalAwards = await haloApiService.GetMedals();

            Maps = await haloApiService.GetMaps();

        }
    }
}
