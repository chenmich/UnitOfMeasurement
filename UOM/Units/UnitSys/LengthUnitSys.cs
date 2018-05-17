using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class LengthUnitSys:IUnitSys
    {
        public  IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Length");
            }
        }
        public  IUnit k{
            get{
                return new kmeter();
            }
        }
        public  IUnit Primary{
            get{
                return new meter();
            }
        }
        public  IUnit Common{
            get{
                return new kmeter();
            }
        }
        public LengthUnitSys(){}
    }
}
