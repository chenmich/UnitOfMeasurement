using System;
using Xunit;
using UOM.Quantities;

namespace UOMTest
{    
    public class QuantityTypeServiceTest
    {
        [Fact]
        public void Test_getType_ByNameId(){
            string l_name = "Length";
            Guid l_id = Guid.Parse("20cc0029-145b-4c8f-bf10-538e624d3fdb");
            QuantityTypeService service = QuantityTypeService.getService();
            IQuantityType lengthType = service.getType(l_name, l_id);
        }
    }
}
