using System;

namespace LeLenhNguyen_2021604114_proj41
{
    class Circle
    {
        private double radius;
        public void setRadius(double radius) { this.radius = radius; }
        public double getRadius() { return radius; }
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area() { return Math.PI * radius * radius; }
        public double Perimeter() {  return 2 * Math.PI * radius; }
    }
}