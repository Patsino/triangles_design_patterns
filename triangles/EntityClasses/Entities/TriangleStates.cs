using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangles.EntityClasses.Entities
{
    [Flags]
    public enum TriangleType
    {
        Invalid = 1,
        Right = 2,
        Isosceles = 4, //ravnobdr
        Equilateral = 8, //ravnostr
        Acute = 16, //ostrii
        Obtuse = 32 //tupoi
    }
}
