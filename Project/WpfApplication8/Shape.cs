using System;
using System.Windows.Controls;

namespace WpfApplication8
{
    abstract class Shape
    {
        public Shape(Canvas canvas)
        {
            _canvas = canvas;
        }

        public virtual void Draw()
        {
            double left = _canvas.ActualWidth * _rand.NextDouble();
            double top = _canvas.ActualHeight * _rand.NextDouble();
            _element.SetValue(Canvas.LeftProperty, left);
            _element.SetValue(Canvas.TopProperty, top);
            _canvas.Children.Add(_element);
        }

        private Canvas _canvas;
        protected System.Windows.Shapes.Shape _element;
        static Random _rand = new Random();
    }
}
