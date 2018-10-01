using System;

namespace Assignment1 {
    public class NotFoundException : Exception {
        public NotFoundException() : base("Station not found"){
            
        }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}
