using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangles.Helpers;


namespace triangles.EntityClasses
{
    public abstract class Shape
    {
        private int Id { get; }

        protected Shape()
        {
            Id = IdGenerator.GenerateId();
        }

        public int GetId()
        {
            return Id;
        }
    }
}
