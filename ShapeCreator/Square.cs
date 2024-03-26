using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeCreator
{
    // Класс генерации квадрата
    internal class Square : IShape
    {
        public object showShape()
        {
            Random random = new Random();
            int side = random.Next(1, 200);
            Console.WriteLine("Визуализация Квадрата");
            Border square = new Border()
            {
                Background = new SolidColorBrush(Colors.Blue),
                Width = side,
                Height = side,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
            };
            return square;
        }

    }
}
