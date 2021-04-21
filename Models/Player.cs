using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadSquared.ApplicationProcess.Models
{
    public class Cost
    {
        public int Food { get; set; }
        public int Wood { get; set; }
    }
    public class GameUnit
    { 
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string expansion { get; set; }
        public string age { get; set; }
        public string created_in { get; set; }
        public Cost cost { get; set; }
        public int build_time { get; set; }
        public double reload_time { get; set; }
        public double attack_delay { get; set; }
        public double movement_rate { get; set; }
        public int line_of_sight { get; set; }
        public int hit_points { get; set; }
        public string range { get; set; }
        public int attack { get; set; }
        public string armor { get; set; }
        public List<string> attack_bonus { get; set; }
        public string accuracy { get; set; }
    }

}