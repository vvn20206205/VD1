using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    class SquarePegAdapter : IRound {
        private ISquare square;
        public ISquare Square { get => square; set => square=value; }
        public SquarePegAdapter(ISquare iSquare) {
            Square=iSquare;
        }
        public float GetRadius() {
            return (float)(Square.GetWidth()*Math.Sqrt(2)/2);
        }
        public override string ToString() {
            return "Đây là đối tượng của lớp SquarePegAdapter.";
        }
    }
}
