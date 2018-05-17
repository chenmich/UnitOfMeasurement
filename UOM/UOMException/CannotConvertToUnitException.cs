using System;
using System.Runtime.Serialization;

namespace UOM.UOMException
{
    public class NotMatchedBetweenQuantityTypeAndUnitException:QuantityException
    {
        public NotMatchedBetweenQuantityTypeAndUnitException():base(){}
        public NotMatchedBetweenQuantityTypeAndUnitException(string message):base(){}

        public NotMatchedBetweenQuantityTypeAndUnitException(string message, Exception inner)
            :base(message, inner){}
        
        public NotMatchedBetweenQuantityTypeAndUnitException(SerializationInfo info, StreamingContext context)
            :base(info, context){}
    }
}
