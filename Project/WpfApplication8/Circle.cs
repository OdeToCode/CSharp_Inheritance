using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication8
{
    class Circle : Shape
    {
        public Circle(Canvas canvas) 
            :base(canvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 10;
            ellipse.Height = 10;
            ellipse.Fill = new SolidColorBrush(Colors.Green);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            _element = ellipse;
        }

        public override void Draw()
        {
            _element.Fill = new SolidColorBrush(Colors.Red);
            base.Draw();
        }
       
    }
}