using System;
using HaloEzAPI.Model.Response.Stats.Halo5;


namespace HaloStatsProject.Variables
{
    public class GetKillDeathRatio
    {
        private MatchPlayer _player { get; set; }
        public double ratio { get; set;}

        public GetKillDeathRatio(MatchPlayer player)
        {
            _player = player;
            KillDeathRatio(_player);
        }

        private void KillDeathRatio(MatchPlayer player)
        {
            if (player.TotalKills == 0)
            {
                ratio = 0;
            }
            else if (player.TotalDeaths == 0)
            {
                ratio = 0;
            }
            else
            {
                ratio = Math.Round((double)player.TotalKills / player.TotalDeaths, 2, MidpointRounding.AwayFromZero);
            }
        }
    }
}
