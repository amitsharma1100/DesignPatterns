using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory
{
    public static class Factory
    {
        public static IMobile CreateMobile(MobileType type)
        {
            IMobile objIMobile = null;

            switch (type)
            {
                case MobileType.Samsung:
                    objIMobile = new Samsung();
                    return objIMobile;

                case MobileType.Apple:
                    objIMobile = new Apple();
                    return objIMobile;

                case MobileType.Nokia:
                    objIMobile = new Nokia();
                    return objIMobile;

                default:
                    return null;
            }
        }
    }
}
