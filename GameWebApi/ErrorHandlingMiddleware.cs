using System;
using System.Runtime.Serialization;

namespace ErrorHandlingMiddleware
{
    
    [Serializable()]
    public class NotFoundException : Exception
    {
        public NotFoundException() : base(String.Format("Player not found")) { }
        public NotFoundException(string message) : base(String.Format(message)) { }
        public NotFoundException(string message, Exception inner) : base(String.Format(message, inner)) { }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

}