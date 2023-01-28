using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    class RoundHole : IRound {
        private float radius;
        public float Radius { get => radius; set => radius=value; }
        public RoundHole(float iRadius) {
            Radius=iRadius;
        }
        public float GetRadius() {
            return Radius;
        }
        public string Fits(IRound iPeg) {
            if(GetRadius()>=iPeg.GetRadius()) {
                return "Kết quả: vừa";
            } else {
                return "Kết quả: không vừa";
            }
        }
        public override string ToString() {
            return "Đây là đối tượng của lớp RoundHole.";
        }

    }
}
