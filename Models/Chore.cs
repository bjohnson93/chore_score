using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Models
{
    public class Chore
    {

        public string Name { get; set; }
        public int? MinutesToComplete { get; set; }
        public bool? Finished { get; set; }
        //? after bool allows finished to be null unless otherwise set
        public double? Rooms { get; set; }

        public Chore(string name, int? minutesToComplete, bool? finished, double? rooms)
        {
            Name = name;
            MinutesToComplete = minutesToComplete;
            Finished = finished;
            Rooms = rooms;
        }

    }

}