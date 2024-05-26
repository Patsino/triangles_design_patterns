using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.EntityClasses.Entities;
using triangles.Helpers;
using triangles.Repository;
using triangles.Repository.RepositoryImpl;
using triangles.Validators;

namespace triangles.Creator.Factory
{
    public class TriangleFactory : IFactory
    {
        private Parser _parser;
        private Validator _validator;
        private TriangleRepository _repository;

        public Triangle CreateTriangle(Point p1, Point p2, Point p3)
        {
            return new Triangle(p1, p2, p3);
        }
        public TriangleFactory()
        {
            _parser = new Parser();
            _validator = new Validator();
            _repository = new TriangleRepository();
        }

        public TriangleFactory(TriangleRepository repository)
        {
            _parser = new Parser();
            _validator = new Validator();
            _repository = repository;
        }

        public List<Triangle> CreateTriangles(string filePath)
        {
            var lines = _parser.ReadFile(filePath);
            if (lines.Length == 0)
            {
                throw new ArgumentException("empty file");
            }

            foreach (var line in lines)
            {
                if (_validator.IsValidLine(line))
                {
                    var parts = line.Split(' ');
                    var p1 = new Point(double.Parse(parts[0]), double.Parse(parts[1]));
                    var p2 = new Point(double.Parse(parts[2]), double.Parse(parts[3]));
                    var p3 = new Point(double.Parse(parts[4]), double.Parse(parts[5]));

                    var triangle = CreateTriangle(p1, p2, p3);
                    if (_validator.IsValidTrianle(triangle))
                    {
                        _repository.AddTriangle(triangle);
                        Log.Information($"Created {triangle}");
                    }
                    else
                    {
                        Log.Error($"invalid triangle {triangle}");
                    }
                }
            }

            return _repository.GetAllTriangles().ToList();
        }
    }
}
