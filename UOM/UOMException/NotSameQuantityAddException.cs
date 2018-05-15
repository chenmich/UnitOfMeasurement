using System;
using System.Runtime.Serialization;

namespace UOM.UOMException
{
    public class NotSameQuantityAddException:QuantityException
    {
        public NotSameQuantityAddException():base(){}
        public NotSameQuantityAddException(string message):base(message){}
        public NotSameQuantityAddException(string message, Exception inner)
            :base(message, inner){}
        
        public NotSameQuantityAddException(SerializationInfo info, StreamingContext context)
            :base(info, context){}
        
    }
}
