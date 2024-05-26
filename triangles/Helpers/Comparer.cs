using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.EntityClasses.Entities;

namespace triangles.Helpers
{
    public class IdComparer : IComparer<Triangle>
    {
        public int Compare(Triangle first, Triangle second) => first.GetId().CompareTo(second.GetId());
    }
}
