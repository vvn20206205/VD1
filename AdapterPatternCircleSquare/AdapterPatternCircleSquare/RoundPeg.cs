using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    class RoundPeg : IRound {
        private float radius;
        public float Radius { get => radius; set => radius=value; }
        public RoundPeg(float iRadius) {
            radius=iRadius;
        }
        public float GetRadius() {
            return radius;
        }
        public override string ToString() {
            return "Đây là đối tượng của lớp RoundPeg.";
        }

    }
}
