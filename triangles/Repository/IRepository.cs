using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.EntityClasses.Entities;

namespace triangles.Repository
{
    public interface ITriangleRepository
    {
        void AddTriangle(Triangle triangle);
        void RemoveTriangle(Triangle triangle);
        IEnumerable<Triangle> GetAllTriangles();
    }
}
