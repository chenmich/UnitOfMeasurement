using System;
using System.Runtime.Serialization;

namespace UOM.UOMException
{
    public class QuantityException:UOMException
    {
        public QuantityException():base(){}
        public QuantityException(string message):base(message){}
        public QuantityException(string message, Exception innerException)
            :base(message, innerException){}
        public QuantityException(SerializationInfo info, StreamingContext context)
            :base(info, context){}
    }
}
