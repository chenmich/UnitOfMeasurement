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
    }
}
