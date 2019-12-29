using System.Collections.Generic;
using System.Threading.Tasks;
using HaloEzAPI;
using HaloEzAPI.Model.Response.MetaData.Halo5;
using HaloEzAPI.Model.Response.Stats.Halo5;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HaloStatsProject.Pages
{
    public class UserModel : PageModel {

        private readonly ILogger<UserModel> _logger;
        public PlayerMatches Matches;

        public IEnumerable<Map> Maps { get; private set; }
        public IEnumerable<Season> SeasonIdName { get; private set; }
        public IEnumerable<GameBaseVariant> GameType { get; private set; }
        public string GamerTag { get; private set; }

        public UserModel (ILogger<UserModel> logger) {
            _logger = logger;
        }

        public async Task OnGet (string GamerTag) {

            var haloApiService = new HaloAPIService ("bdd5cbaf0ca34682a8f6b50742747e6f", "https://www.haloapi.com");

            Matches = await haloApiService.GetMatchesForPlayer (GamerTag, HaloEzAPI.Abstraction.Enum.Halo5.GameMode.Arena, count : 100);
            Maps = await haloApiService.GetMaps ();
            SeasonIdName = await haloApiService.GetSeasons ();
            GameType = await haloApiService.GetGameBaseVariants ();
        }
    }
}