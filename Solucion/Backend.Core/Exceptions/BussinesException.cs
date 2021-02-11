using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Core.Exceptions
{
    public class BussinesException : Exception
    {
        public BussinesException()
        {

        }

        public BussinesException(string message) : base(message)
        {

        }

        public BussinesException(string message, Exception exception): 
            base(message, exception)
        {

        }
    }
}
