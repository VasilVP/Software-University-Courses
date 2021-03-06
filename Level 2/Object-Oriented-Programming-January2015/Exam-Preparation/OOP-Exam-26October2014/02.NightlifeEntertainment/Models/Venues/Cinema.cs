﻿namespace NightlifeEntertainment.Models.Venues
{
    using System;
    using System.Collections.Generic;

    public class Cinema : Venue
    {
        public Cinema(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, new List<PerformanceType> { PerformanceType.Movie, PerformanceType.Concert })
        {
        }
    }
}
