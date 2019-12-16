using System;
using System.Collections.Generic;

namespace HaloStatsProject.Models
{
    public class XpInfo
    {
        public int PrevSpartanRank { get; set; }
        public int SpartanRank { get; set; }
        public int PrevTotalXP { get; set; }
        public int TotalXP { get; set; }
        public double SpartanRankMatchXPScalar { get; set; }
        public int PlayerTimePerformanceXPAward { get; set; }
        public int PerformanceXP { get; set; }
        public int PlayerRankXPAward { get; set; }
        public int BoostAmount { get; set; }
        public int MatchSpeedWinAmount { get; set; }
        public int ObjectivesCompletedAmount { get; set; }
    }

    public class PreviousCsr
    {
        public int Tier { get; set; }
        public int DesignationId { get; set; }
        public int Csr { get; set; }
        public int PercentToNextTier { get; set; }
        public object Rank { get; set; }
    }

    public class CurrentCsr
    {
        public int Tier { get; set; }
        public int DesignationId { get; set; }
        public int Csr { get; set; }
        public int PercentToNextTier { get; set; }
        public object Rank { get; set; }
    }

    public class KilledOpponentDetail
    {
        public string GamerTag { get; set; }
        public int TotalKills { get; set; }
    }

    public class KilledByOpponentDetail
    {
        public string GamerTag { get; set; }
        public int TotalKills { get; set; }
    }

    public class ImpulseStatCount
    {
        public string Id { get; set; }
        public int Count { get; set; }
    }

    public class ImpulseTimelaps
    {
        public string Id { get; set; }
        public string Timelapse { get; set; }
    }

    public class FlexibleStats
    {
        public List<object> MedalStatCounts { get; set; }
        public List<ImpulseStatCount> ImpulseStatCounts { get; set; }
        public List<object> MedalTimelapses { get; set; }
        public List<ImpulseTimelaps> ImpulseTimelapses { get; set; }
    }

    public class CreditsEarned
    {
        public int Result { get; set; }
        public int TotalCreditsEarned { get; set; }
        public double SpartanRankModifier { get; set; }
        public int PlayerRankAmount { get; set; }
        public double TimePlayedAmount { get; set; }
        public int BoostAmount { get; set; }
        public int MatchSpeedWinAmount { get; set; }
        public int ObjectivesCompletedAmount { get; set; }
    }

    public class ProgressiveCommendationDelta
    {
        public string Id { get; set; }
        public int PreviousProgress { get; set; }
        public int Progress { get; set; }
    }

    public class BoostInfo
    {
        public string DefinitionId { get; set; }
        public bool CardConsumed { get; set; }
    }

    public class Player
    {
        public string Gamertag { get; set; }
        public object Xuid { get; set; }
    }

    public class WeaponId
    {
        public object StockId { get; set; }
        public List<object> Attachments { get; set; }
    }

    public class WeaponWithMostKills
    {
        public WeaponId WeaponId { get; set; }
        public int TotalShotsFired { get; set; }
        public int TotalShotsLanded { get; set; }
        public int TotalHeadshots { get; set; }
        public int TotalKills { get; set; }
        public double TotalDamageDealt { get; set; }
        public string TotalPossessionTime { get; set; }
    }

    public class MedalAward
    {
        public object MedalId { get; set; }
        public int Count { get; set; }
    }

    public class WeaponId2
    {
        public object StockId { get; set; }
        public List<object> Attachments { get; set; }
    }

    public class WeaponStat
    {
        public WeaponId2 WeaponId { get; set; }
        public int TotalShotsFired { get; set; }
        public int TotalShotsLanded { get; set; }
        public int TotalHeadshots { get; set; }
        public int TotalKills { get; set; }
        public double TotalDamageDealt { get; set; }
        public string TotalPossessionTime { get; set; }
    }

    public class PlayerStat
    {
        public XpInfo XpInfo { get; set; }
        public PreviousCsr PreviousCsr { get; set; }
        public CurrentCsr CurrentCsr { get; set; }
        public int MeasurementMatchesLeft { get; set; }
        public List<object> RewardSets { get; set; }
        public List<KilledOpponentDetail> KilledOpponentDetails { get; set; }
        public List<KilledByOpponentDetail> KilledByOpponentDetails { get; set; }
        public FlexibleStats FlexibleStats { get; set; }
        public CreditsEarned CreditsEarned { get; set; }
        public List<object> MetaCommendationDeltas { get; set; }
        public List<ProgressiveCommendationDelta> ProgressiveCommendationDeltas { get; set; }
        public BoostInfo BoostInfo { get; set; }
        public Player Player { get; set; }
        public int TeamId { get; set; }
        public int Rank { get; set; }
        public bool DNF { get; set; }
        public string AvgLifeTimeOfPlayer { get; set; }
        public object PreMatchRatings { get; set; }
        public object PostMatchRatings { get; set; }
        public int PlayerScore { get; set; }
        public int GameEndStatus { get; set; }
        public int TotalKills { get; set; }
        public int TotalHeadshots { get; set; }
        public double TotalWeaponDamage { get; set; }
        public int TotalShotsFired { get; set; }
        public int TotalShotsLanded { get; set; }
        public WeaponWithMostKills WeaponWithMostKills { get; set; }
        public int TotalMeleeKills { get; set; }
        public double TotalMeleeDamage { get; set; }
        public int TotalAssassinations { get; set; }
        public int TotalGroundPoundKills { get; set; }
        public double TotalGroundPoundDamage { get; set; }
        public int TotalShoulderBashKills { get; set; }
        public double TotalShoulderBashDamage { get; set; }
        public double TotalGrenadeDamage { get; set; }
        public int TotalPowerWeaponKills { get; set; }
        public double TotalPowerWeaponDamage { get; set; }
        public int TotalPowerWeaponGrabs { get; set; }
        public string TotalPowerWeaponPossessionTime { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalAssists { get; set; }
        public int TotalGamesCompleted { get; set; }
        public int TotalGamesWon { get; set; }
        public int TotalGamesLost { get; set; }
        public int TotalGamesTied { get; set; }
        public string TotalTimePlayed { get; set; }
        public int TotalGrenadeKills { get; set; }
        public List<MedalAward> MedalAwards { get; set; }
        public List<object> DestroyedEnemyVehicles { get; set; }
        public List<object> EnemyKills { get; set; }
        public List<WeaponStat> WeaponStats { get; set; }
        public List<object> Impulses { get; set; }
        public int TotalSpartanKills { get; set; }
        public object FastestMatchWin { get; set; }
    }

    public class RoundStat
    {
        public int RoundNumber { get; set; }
        public int Rank { get; set; }
        public int Score { get; set; }
    }

    public class TeamStat
    {
        public int TeamId { get; set; }
        public int Score { get; set; }
        public int Rank { get; set; }
        public List<RoundStat> RoundStats { get; set; }
    }

    public class GameVariantResourceId
    {
        public int ResourceType { get; set; }
        public string ResourceId { get; set; }
        public int OwnerType { get; set; }
        public string Owner { get; set; }
    }

    public class MapVariantResourceId
    {
        public int ResourceType { get; set; }
        public string ResourceId { get; set; }
        public int OwnerType { get; set; }
        public string Owner { get; set; }
    }

    public class RootObject
    {
        public List<PlayerStat> PlayerStats { get; set; }
        public List<TeamStat> TeamStats { get; set; }
        public bool IsMatchOver { get; set; }
        public string TotalDuration { get; set; }
        public string MapVariantId { get; set; }
        public string GameVariantId { get; set; }
        public string PlaylistId { get; set; }
        public string MapId { get; set; }
        public string GameBaseVariantId { get; set; }
        public bool IsTeamGame { get; set; }
        public string SeasonId { get; set; }
        public GameVariantResourceId GameVariantResourceId { get; set; }
        public MapVariantResourceId MapVariantResourceId { get; set; }
    }
}
