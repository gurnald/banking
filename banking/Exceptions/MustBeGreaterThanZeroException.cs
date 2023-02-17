using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking.Exceptions;
internal class MustBeGreaterThanZeroException : Exception {

    public MustBeGreaterThanZeroException() : base() { } 
    
    public MustBeGreaterThanZeroException(string message) : base(message) { }

    public MustBeGreaterThanZeroException(string message, Exception InnerException) :
        base(message, InnerException) { }   

}
