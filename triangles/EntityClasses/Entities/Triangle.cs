using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangles.EntityClasses.Entities
{
    public class Triangle : Shape
    {
        private Point _point1;
        private Point _point2;
        private Point _point3;

        public Triangle(Point point1, Point point2, Point point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        public override string ToString()
        {
            return $"({_point1.ToString()}, / {_point2.ToString()},/ {_point3.ToString()}, id {GetId()})";
        }
    }
}
