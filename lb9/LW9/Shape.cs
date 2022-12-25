using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW9
{
    public abstract class Shape : IDraw
    {
        public abstract string Color { get; set; }
        public abstract int CountOfVertices { get;}
        public abstract string Name { get; }
        public abstract double Area();

        public abstract void Draw();

        public abstract double Perimeter();
    }
}
