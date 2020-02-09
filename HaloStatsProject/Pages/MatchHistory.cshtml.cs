using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HaloEzAPI;
using HaloEzAPI.Model.Response.MetaData.Halo5;
using HaloEzAPI.Model.Response.Stats.Halo5;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
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
        public Dictionary<string, GameVariant> gameVariants;

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
            var d = new Dictionary<string, GameVariant>();
            List<string> m = Matches.Results.Select(match => match.GameVariant.ResourceId.ToString()).ToList();
            foreach (var item in m)
            {
                var res = await haloAPIService.GetGameVariant(item);

                if (!d.Keys.Contains(item))
                {
                    d.Add(item, res);
                }

                if (d.Keys.Count == 25)
                {
                    break;
                }

                await Task.Delay(1000);
                
            }

            gameVariants = d;


        }
    }
}