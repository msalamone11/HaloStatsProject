using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HaloEzAPI;
using HaloEzAPI.Model.Response.MetaData.Halo5;
using HaloEzAPI.Model.Response.Stats.Halo5;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HaloEzAPI.Model.Response.Stats.Halo5.Arena;
using System.Linq;

namespace HaloStatsProject.Pages
{
    public class UserModel : PageModel {

        private readonly ILogger<UserModel> _logger;
        public PlayerMatches Matches;

        public IEnumerable<Map> Maps { get; private set; }
        public IEnumerable<Season> SeasonIdName { get; private set; }
        public IEnumerable<GameBaseVariant> GameType { get; private set; }
        public string GamerTag { get; private set; }
        public GameVariant GameTypeName;
        public HaloAPIService haloAPIService { get; set; }
        public List<GameVariant> gameVariants;

        public UserModel (ILogger<UserModel> logger) {
            _logger = logger;
            haloAPIService = new HaloAPIService("bdd5cbaf0ca34682a8f6b50742747e6f", "https://www.haloapi.com");
        }

        public async Task OnGet (string GamerTag) {

            //haloAPIService = new HaloAPIService ("bdd5cbaf0ca34682a8f6b50742747e6f", "https://www.haloapi.com");

            Matches = await haloAPIService.GetMatchesForPlayer (GamerTag, HaloEzAPI.Abstraction.Enum.Halo5.GameMode.Arena, count : 100);
            Maps = await haloAPIService.GetMaps ();
            SeasonIdName = await haloAPIService.GetSeasons ();
            GameType = await haloAPIService.GetGameBaseVariants ();

            var m = Matches.Results.Select(match => match.GameVariant.ResourceId.ToString()).ToList();

            var l = new List<GameVariant>();

            foreach (var item in m)
            {
                l.Add(await haloAPIService.GetGameVariant(item));
            }

            gameVariants = l;

        }
    }
}