using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class ColoredFigure
    {
        public string Color { get;protected set; }
        public int Size { get; protected set; }

        public ColoredFigure(string color, int size)
        {
            this.Color = color;
            this.Size = size;
        }

        public virtual string Show()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"Color: {this.Color}").AppendLine();
            stringBuilder.AppendFormat($"Size: {this.Size}");
            return stringBuilder.ToString();
        }
        public abstract string GetName();

        public abstract double GetArea();
    }
}
