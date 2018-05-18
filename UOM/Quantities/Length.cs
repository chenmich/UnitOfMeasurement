using System;
using UOM.Units;

namespace UOM.Quantities
{
    public class Length:Quantity{
        public Length(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Length");
            Unit = new meter();
        }
        public Length(float value):this(){
            Unit = Type.Sys.Primary;
            Value = value;
        }

        public Length(IUnit unit, float value):this(value){
            Unit = unit;
        }
    }
}