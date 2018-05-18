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
            QuantityTypeService service = QuantityTypeService.getService();
            IQuantityType ttype = service.getType("Time");
            IQuantityType vtype = service.getType("Velocity");
            IQuantityType ltype = ttype.Multiply(vtype);
            Assert.Equal("Length", ltype.Id.Name);
            IQuantityType ltype1 = vtype.Multiply(ttype);
            Assert.Equal("Length", ltype1.Id.Name);
        } 
        [Fact]
        public void Test_Divide(){
            QuantityTypeService service = QuantityTypeService.getService();
            IQuantityType ltype = service.getType("Length");
            IQuantityType ttype = service.getType("Time");
            IQuantityType vtype = ltype.Divide(ttype);
            Assert.Equal("Velocity", vtype.Id.Name);
        } 
    }
}
