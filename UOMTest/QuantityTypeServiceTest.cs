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
            Assert.Equal(lengthType.Id.Id, l_id);
            Assert.Equal(lengthType.Id.Name, l_name);
            Assert.IsAssignableFrom<QuantityType>(lengthType);
        }
        [Fact]
        public void Test_getType_ByExpression(){
            QuantityTypeService service = QuantityTypeService.getService();
            string acceleration_name = "Acceleration";
            Guid acc_id = Guid.Parse("f4955e08-928b-4d1e-8cd1-16ef3c31ca27");
            IQuantityType accType = service.getType(acceleration_name, acc_id);
            
            string velocity_name = "Velocity";
            Guid velocity_id = Guid.Parse("c2c128f7-7cf5-47a3-a51e-ebbc79b30c82");
            IQuantityType velType = service.getType(velocity_name, velocity_id);

            string time_name = "Time";
            Guid time_id = Guid.Parse("202fa543-23c5-405b-94da-a878d372cc8f");
            IQuantityType timeType = service.getType(time_name, time_id);

            TypeExpression acc_typeExp = 
                new TypeExpression(velType, timeType, TypeOperator.Divide);
            TypeExpression vel_typeExp = 
                new TypeExpression(accType, timeType, TypeOperator.Multiply);
            TypeExpression another_vel_typeExp = 
                new TypeExpression(timeType, accType, TypeOperator.Multiply);
            TypeExpression time_typeExp =
                new TypeExpression(velType, accType, TypeOperator.Divide);

            Assert.True(accType.Equals(service.getType(acc_typeExp)));
            Assert.True(velType.Equals(service.getType(vel_typeExp)));
            Assert.True(velType.Equals(service.getType(another_vel_typeExp)));
            Assert.True(timeType.Equals(service.getType(time_typeExp)));
        }
        
        
    }
}
