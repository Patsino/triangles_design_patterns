#pragma warning disable
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
            Warehouse.Warehouse.Instance.AddTriangle(triangle);
        }

        public void RemoveTriangle(Triangle triangle)
        {
            _triangles.Remove(triangle);
            Warehouse.Warehouse.Instance.RemoveTriangle(triangle);
        }

        public Triangle GetSphereById(int id)
        {
            return _triangles.Find(s => s.GetId() == id);
        }

        public IEnumerable<Triangle> GetAllTriangles()
        {
            return _triangles;
        }

        public IEnumerable<Triangle> SortTriangles(IComparer<Triangle> comparer)
        {
            return _triangles.OrderBy(t => t, comparer);
        }
    }
}
