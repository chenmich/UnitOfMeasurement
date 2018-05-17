using System;
using UOM.Units;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class AccelerationUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Acceleration");
            }
        }
        public  IUnit k{
            get{
                return new kmeterpersecondsquare();
            }
        }

        public  IUnit Primary{
            get{
                return new meterpersecondsquare();
            }
        }

        public  IUnit Common{
            get{
                return new meterpersecondsquare();
            }
        }

        public AccelerationUnitSys(){
            
        }
    }
}