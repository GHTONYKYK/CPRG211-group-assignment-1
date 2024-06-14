using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDomain
{
    public class Dishwasher : MyAppliance
    {
            public string Feature { get; }
            public string SoundRating { get; }
            public override string ToString()
                => base.ToString() +
                $"Feature: {Feature}\n + SoundRating: {SoundRating}";

    }
}

