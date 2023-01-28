using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    class SquarePeg : ISquare {
        private float width;
        public float Width { get => width; set => width=value; }
        public SquarePeg(float iWidth) {
            Width=iWidth;
        }
        public float GetWidth() {
            return Width;
        }
    }
}
