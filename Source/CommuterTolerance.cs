using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICities;
using UnityEngine;

namespace CommuterTolerance.Source
{
    public class CommuterTolerance : IUserMod
    {
        public string Name
        {
            get { return "Commuter Tolerance"; }
        }

        public string Description
        {
            get { return "This mod increases the distance cims are willing to travel for work, allowing more widespread cities without causing stores and factories to close due to lack of workers."; }
        }
    }
}