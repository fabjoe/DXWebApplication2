using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NbaPlayersManager2.Models
{
    public class Player
    {
        public string PlayerID { get; set; }
        public string PlayerName { get; set; }
        public decimal MinsPerGame { get; set; }
        public decimal EffPerGame { get; set; }
        public decimal EffMin { get; set; }
        public int GamesPlayed { get; set; }
        public decimal FieldsGoalPercentage { get; set; }
        public decimal ThreePointsPercentage { get; set; }
        public decimal FreeThrowsPercentage { get; set; }
        public decimal ReboundsPerGame { get; set; }
        public decimal AssistsPerGame { get; set; }
        public decimal StealsPerGame { get; set; }
        public decimal BlocksPerGame { get; set; }
        public decimal TurnoversPerGame { get; set; }
        public decimal PointsPerGame { get; set; }
    }
}