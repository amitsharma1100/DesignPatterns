using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory
{
    class Nokia : IMobile
    {
        public Mobile GetMobile()
        {
            return new Mobile
            {
                ModelName = "Nokia Lumia 960",
                OperatingSystem = "Nokia Uses Symbion OS for Lumia Mobile series ",
            };
        }
    }
}
