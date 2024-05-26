using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.EntityClasses.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace triangles.Validators
{
    public class Validator
    {
        public bool IsValidLine(string line)
        {
            var parts = line.Split(' ');

            // Check if there are exactly 6 parts (3 points with 2 coordinates each)
            if (parts.Length != 6)
            {
                Log.Warning($"Invalid line: {line}");
                return false;
            }

            // Check if all parts can be parsed to double
            return parts.All(part =>
            {
                double temp;
                return double.TryParse(part, out temp);
            });
        }

        public bool IsValidTrianle(Triangle triangle)
        {
            return triangle.GetState() != TriangleType.Invalid;
        }
    }
}
