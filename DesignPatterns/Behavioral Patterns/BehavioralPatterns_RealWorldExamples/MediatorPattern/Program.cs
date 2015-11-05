﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatorPattern.ConcreteColleagues;
using MediatorPattern.ConcreteMediator;

namespace MediatorPattern
{//PLURALSIGHT
    class Program
    {
        static void Main(string[] args)
        {
            var regionalATC = new RegionalAirTrafficControl();
            var aircraft1 = new Airbus380("AI568", regionalATC);
            var aircraft2 = new Boeing747("BA157", regionalATC);
            var aircraft3 = new Airbus380("LW111", regionalATC);

            aircraft1.Altitude += 100;

            aircraft3.Altitude = 1100;
        }
    }
}
