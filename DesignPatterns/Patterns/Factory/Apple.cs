using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory
{
    class Apple : IMobile
    {
        public Mobile GetMobile()
        {
            return new Mobile
            {
                ModelName = "Apple IPhone 5",
                OperatingSystem = "Apple Uses ios OS for Apple Mobiles ",
            };
        }
    }
}
