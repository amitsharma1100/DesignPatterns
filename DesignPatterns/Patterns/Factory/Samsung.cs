using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory
{
    public class Samsung : IMobile
    {
        public Mobile GetMobile()
        {
            return new Mobile
            {
                ModelName = "Samsung Galaxy Grand",
                OperatingSystem = "Samsung Uses Android OS For Galaxy Mobile series ",
            };
        }
    }
}
