using AbstractClasses;

namespace AbstractClasses.BaseFigures;


    internal class Rectangle : Triangle  // прямоугольник
    {
        private double sideA;
        private double sideB;

        protected Rectangle() { }
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override double Square()
        {
            return sideA * sideB;
        }

        public override double Perimeter()
        {
            return (sideA + sideB) * 2;
        }
    }
