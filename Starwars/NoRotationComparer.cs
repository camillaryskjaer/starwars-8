using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    class NameComparer : IEqualityComparer<Planet>
    {
        public bool Equals(Planet x, Planet y)
        {
            if (string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(Planet obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    public class RotationComparer : IEqualityComparer<Planet>
    {
        public bool Equals(Planet x, Planet y)
        {
            return (x.RotationPeriod == y.RotationPeriod);
        }

        public int GetHashCode(Planet obj)
        {
            return obj.RotationPeriod.GetHashCode();
        }
    }
}
