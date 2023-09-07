namespace CalcFigureLib
{
    public class Circle : IFigure
    {

        public double _Radius { get;}

        public Circle(double Radius) 
        {
            if (Radius <= 0)
                throw new ArgumentException($"{nameof(Radius)} не может быть равен или отрицателен нулю");
            _Radius = Radius;
        }

        public double GetSqure()
        {
            return Math.PI * Math.Pow(_Radius, 2);
        }
    }
}