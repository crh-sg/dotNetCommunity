using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipleApplied
{
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
