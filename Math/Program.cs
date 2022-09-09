using System;

namespace Calculater
{ 
    interface IMathArea
    {
        double Area();
    }
    class Circle : IMathArea
    {
        private double Radius;
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public double Area() => Math.PI * Radius * Radius; 
    }
    class Triangle : IMathArea
    {
        private double Hipot;
        private double Katet1;
        private double Katet2;
        public Triangle(double SideA, double SideB, double SideC)
        {
            if (SideA > SideB)
            {
                if (SideC > SideA) {
                    Hipot = SideC;
                    Katet1 = SideA;
                    Katet2 = SideB;
                }
                else {
                    Hipot = SideA;
                    Katet1 = SideB;
                    Katet2 = SideC;
                }
            }
            else
            {
                if (SideC > SideB)
                {
                    Hipot = SideC;
                    Katet1 = SideA;
                    Katet2 = SideB;
                }
                else {
                    Hipot = SideB;
                    Katet1 = SideA;
                    Katet2 = SideC;
                }
            }
        }
        public double Area()
        {
            if (Rectangular())
                return Katet1 * Katet2 / 2;
            double p = (Hipot + Katet2 + Katet1) / 2;
            return p * (p - Hipot) * (p - Katet1) * (p - Katet2);
        } 
        private bool Rectangular() => Hipot * Hipot == Katet1 * Katet1 + Katet2 * Katet2;
    }  
    public static class Fabrica
    {
        static IMathArea area;
        public static double Repository(string name,params double[] side)
        { 
            switch (name)
            {
                case "Triangle":
                    area = new Triangle(side[0], side[1], side[2]);
                    break; 
                case "Circle":
                    area = new Circle(side[0]);
                    break;
                default:
                    new Exception("Нет такой фигуры");
                    break;
            }
            return area.Area();
        }
    }
}
