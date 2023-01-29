using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    /// <summary>
    /// Dùng Adapter "Đóng giả" làm trụ tròn ngoại tiếp trụ vuông​
    /// Bán kính của trụ tròn = Cạnh của trụ vuông / căn 2
    /// </summary>
    class SquarePegAdapter : IRound {
        #region Fields 
        private ISquare square;
        #endregion
        #region Properties 
        public ISquare Square { get => square; set => square=value; }
        #endregion
        #region Constructor
        public SquarePegAdapter(ISquare iSquare) {
            Square=iSquare;
        }
        #endregion
        #region Methods 
        public float GetRadius() {
            return (float)(Square.GetWidth()*Math.Sqrt(2)/2);
        }
        public override string ToString() {
            return "Đây là đối tượng của lớp SquarePegAdapter.";
        }
        #endregion
    }
}
