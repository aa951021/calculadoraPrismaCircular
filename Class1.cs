using System;
namespace Application
{
    public class Class1
    {
        public double CalcularArea(double r, double h)
        {
             double area = (Math.PI + Math.PI * (r * r)  + Math.PI + Math.PI * r * h);
             return area;
        }
        public double CalcularVolumen(double r, double h)
        {
            double volumen = (Math.PI * (r * r) * h);
            return volumen;
        }
    }
}