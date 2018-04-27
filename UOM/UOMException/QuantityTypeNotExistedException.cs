using System;
using System.Runtime.Serialization;

namespace UOM.UOMException
{
    public class QuantityTypeNotExistedException:QuantityException
    {
        public QuantityTypeNotExistedException():base(){}
        public QuantityTypeNotExistedException(string message)
            :base(message){}
        public QuantityTypeNotExistedException(string message, Exception innerException)
            :base(message, innerException){}
        public QuantityTypeNotExistedException(SerializationInfo info, StreamingContext context)
            :base(info, context){}

    }
}
