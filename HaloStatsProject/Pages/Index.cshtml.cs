using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HaloStatsProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HaloStatsProject.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        public RootObject PlayerStats;

        public IndexModel (ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet () {
            var client = new HttpClient ();
            client.BaseAddress = new Uri ("https://www.haloapi.com/");
            client.DefaultRequestHeaders.Add ("Ocp-Apim-Subscription-Key", "bdd5cbaf0ca34682a8f6b50742747e6f");
            client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));
            string result = client.GetStringAsync ("stats/h5/arena/matches/1d8e6578-947e-4855-a86f-85a014a748df").Result;
            PlayerStats = JsonConvert.DeserializeObject<RootObject> (result);
            PlayerStats.PlayerStats.OrderBy (player => player.TeamId).OrderBy (player => player.Rank);
            DataTable matchDataTable = new DataTable ();

        }
        public RedirectToPageResult OnPost () {
            var GamerTag = Request.Form["GamerTag"];
            return RedirectToPage ("Player", new { GamerTag = GamerTag });
        }
    }
}