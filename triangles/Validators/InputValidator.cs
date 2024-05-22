using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return false;
            }

            // Check if all parts can be parsed to double
            return parts.All(part =>
            {
                double temp;
                return double.TryParse(part, out temp);
            });
        }
    }
}
