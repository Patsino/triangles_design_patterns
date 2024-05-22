using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using triangles.EntityClasses.Entities;

namespace triangles.Creator
{
    public interface IFactory
    {
        Triangle CreateTriangle(Point p1, Point p2, Point p3);

        List<Triangle> CreateTriangles(string FilePath);
    }
}
