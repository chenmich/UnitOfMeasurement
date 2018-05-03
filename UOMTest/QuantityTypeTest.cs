using System;
using Xunit;
using UOM.Quantities;

namespace UOMTest
{
    public class QuantityTypeTest
    {
        [Fact]
        public void Test_GetQuaantity(){
            QuantityTypeService service = QuantityTypeService.getService();
            QuantityType ltype = service.getType("Length") as QuantityType;
            IQuantity l = ltype.getQuantity();
            Assert.IsType<Length>(l);
        }

        [Fact]
        public void Test_Multiply(){
            Time t = new Time();
            Velocity v = new Velocity();
            IQuantity l = v.Multiply(t);
            Assert.IsType<Length>(l);
        } 
        [Fact]
        public void Test_Divide(){
            Time t = new Time();
            Length l = new Length();
            IQuantity v = l.Divide(t);
            Assert.IsType<Velocity>(v);
        } 
    }
}
