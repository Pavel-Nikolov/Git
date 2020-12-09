using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<ColoredFigure> coloredFigures = new List<ColoredFigure>();
            string command;
            for (int i = 0; i < N; i++)
            {
                command = Console.ReadLine();
                coloredFigures.Add(ParseCommand(command));
            }

            foreach (var item in coloredFigures)
            {
                Console.WriteLine($"{item.GetName()}:");
                Console.WriteLine(item.Show());
                Console.WriteLine($"Area: {item.GetArea():f2}");
            }
        }

        public static ColoredFigure ParseCommand(string command)
        {
            string[] elements = command.Split();
            string color = elements[1];
            int size = int.Parse(elements[2]);

            switch (elements[0])
            {
                case "Triangle": return new Triangle(color, size);
                case "Square": return new Square(color, size);
                case "Circle": return new Circle(color, size);
                default:
                    throw new ArgumentException("Invalid figure");
                  
            }
        }
    }
}
