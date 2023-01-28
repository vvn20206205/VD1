using System;

namespace AdapterPatternCircleSquare {
    /// <summary>
    /// Custom Exception 
    /// </summary>
    class InvalidLengthException : Exception {
        // Bạn phải nhập độ dài là số thực và không âm.
        public InvalidLengthException()
        : base("Bạn phải nhập độ dài là số thực và không âm.") { }
    }
}