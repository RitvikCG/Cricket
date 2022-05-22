﻿using System;
using System.Collections.Generic;

namespace Cricket1Application2.Models
{
    public partial class Matches
    {
        public int MatchId { get; set; }
        public int? StadiumId { get; set; }
        public int? Team1 { get; set; }
        public int? Team2 { get; set; }
        public string Result { get; set; }
        public DateTime? DateTime { get; set; }
        public string WasMatchPlayed { get; set; }

        public Stadium Stadium { get; set; }
        public Country Team1Navigation { get; set; }
        public Country Team2Navigation { get; set; }
    }
}
