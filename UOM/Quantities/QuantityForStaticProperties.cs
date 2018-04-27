using System;

namespace UOM.Quantities
{
    public partial class Quantity:IQuantity
    {
        public static IQuantity Length{
            get{
                return new Quantity("Length");
            }
        }
    }
}
