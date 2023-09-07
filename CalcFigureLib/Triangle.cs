using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFigureLib
{
    public class Triangle : IFigure
    {
        public double _edgeA { get; }
        public double _edgeB { get; }
        public double _edgeC { get; }

        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA <= 0 || edgeB <= 0 || edgeC <= 0)
                throw new ArgumentException($"Сторонная триугольника не может быть меньше или равно нулю. {nameof(edgeA)}:{edgeA}, {nameof(edgeB)}:{edgeB}, {nameof(edgeC)}:{edgeC}");


            _edgeA = edgeA;
            _edgeB = edgeB;
            _edgeC = edgeC;


        }

        public bool GetIsTriangleRight()
        {
            if (Math.Pow(_edgeB, 2) + Math.Pow(_edgeC, 2) == Math.Pow(_edgeC, 2))
                return true;
            if (Math.Pow(_edgeB, 2) + Math.Pow(_edgeC, 2) == Math.Pow(_edgeA, 2))
                return true;
            if (Math.Pow(_edgeB, 2) + Math.Pow(_edgeC, 2) == Math.Pow(_edgeA, 2))
                return true;
            else 
                return false;
        }
        

        public double GetSqure()
        {
            double semiP = (_edgeA + _edgeB + _edgeC) / 2; //поиск полупериметра
            return Math.Sqrt(semiP*(semiP - _edgeA) * (semiP - _edgeB) * (semiP - _edgeC));

        }
    }
}
