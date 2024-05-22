using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.EntityClasses.Entities;

namespace triangles.Repository.RepositoryImpl
{
    public class TriangleRepository : ITriangleRepository
    {
        private List<Triangle> _triangles;

        public TriangleRepository()
        {
            _triangles = new List<Triangle>();
        }

        public void AddTriangle(Triangle triangle)
        {
            _triangles.Add(triangle);
        }

        public void RemoveTriangle(Triangle triangle)
        {
            _triangles.Remove(triangle);
        }

        public IEnumerable<Triangle> GetAllTriangles()
        {
            return _triangles;
        }
    }
}
