using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : ColoredFigure
    {
        public Circle(string color, int size) : base(color, size)
        {

        }

        public override string GetName()
        {
            return "Circle";
        }
        public override double GetArea()
        {
            return Size * Size * Math.PI;
        }
    }
}
