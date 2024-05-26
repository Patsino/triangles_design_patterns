using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.ActionClasses.Services;

namespace triangles.EntityClasses.Entities
{
    public class Triangle : Shape
    {
        public Point _point1 { get; set; }
        public Point _point2 { get; set; }
        public Point _point3 { get; set; }
        private TriangleType _triangleType;

        public Triangle(Point point1, Point point2, Point point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _triangleType = TriangleServices.DetermineTriangleType(point1, point2, point3);
        }

        public TriangleType GetState() => _triangleType;
        public override string ToString()
        {
            return $"({_point1}, / {_point2},/ {_point3}, id {GetId()}, state {_triangleType})";
        }
    }
}
