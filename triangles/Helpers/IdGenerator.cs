using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangles.Helpers
{
    public static class IdGenerator
    {
        private static int _idCounter = 0;

        public static int GenerateId() => ++_idCounter;
    }
}
