using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Lib
{
    
        class PhoneException : Exception
        {
            public PhoneException(string message) : base(message) { }
        }

        class InvalidRamException : PhoneException
        {
            public InvalidRamException() : base("Phone with this ram does not exist") { }
        }
    
}
