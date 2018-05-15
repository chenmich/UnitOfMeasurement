using System;
using System.Runtime.Serialization;

namespace UOM.UOMException
{
    public class CannotConvertToUnitException:QuantityException
    {
        public CannotConvertToUnitException():base(){}
        public CannotConvertToUnitException(string message):base(){}

        public CannotConvertToUnitException(string message, Exception inner)
            :base(message, inner){}
        
        public CannotConvertToUnitException(SerializationInfo info, StreamingContext context)
            :base(info, context){}
    }
}
