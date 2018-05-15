using System;
using System.Runtime.Serialization;

namespace UOM.UOMException
{
    public class NotSameQuantityForAddOrSubstractException:QuantityException
    {
        public NotSameQuantityForAddOrSubstractException():base(){}
        public NotSameQuantityForAddOrSubstractException(string message):base(message){}
        public NotSameQuantityForAddOrSubstractException(string message, Exception inner)
            :base(message, inner){}
        
        public NotSameQuantityForAddOrSubstractException(SerializationInfo info, StreamingContext context)
            :base(info, context){}
        
    }
}
