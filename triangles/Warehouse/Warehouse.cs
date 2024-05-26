using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.ActionClasses.Services;
using triangles.EntityClasses.Entities;

namespace triangles.Warehouse
{
    public class Warehouse
    {
        private static Warehouse _instance;
        public static Warehouse Instance => _instance ??= new Warehouse();

        private Dictionary<Triangle, (double Perimeter, double Square)> triangleMetrics = new Dictionary<Triangle, (double, double)>();

        private Warehouse() { }

        public void AddTriangle(Triangle triangle)
        {
            triangleMetrics.TryAdd(triangle, (TriangleServices.CalculatePerimeter(triangle), TriangleServices.CalculateArea(triangle)));
        }

        public void UpdateTriangleMetrics(Triangle triangle)
        {
            triangleMetrics[triangle] = (TriangleServices.CalculatePerimeter(triangle), TriangleServices.CalculateArea(triangle));
        }

        public void RemoveTriangle(Triangle triangle)
        {
            triangleMetrics.Remove(triangle);
        }

        public (double Perimeter, double triangleMetrics) GetTriangleMetrics(Triangle triangle)
        {
            return triangleMetrics.TryGetValue(triangle, out var metrics) ? metrics : (0, 0);
        }
    }
}
