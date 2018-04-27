using System;
using System.Runtime.Serialization;

namespace UOM.UOMException
{
    public class UOMException:Exception
    {
        public UOMException():base(){}
        public UOMException(string message):base(message){}
        public UOMException(string message, Exception innerException)
            :base(message, innerException){}
        public UOMException(SerializationInfo info, StreamingContext context)
            :base(info, context){}
    }
}
