using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class TimeUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Time");
            }
        }
        public  IUnit k{
            get{
                return new ksecond();
            }
        }

        public  IUnit Primary{
            get{
                return new second();
            }
        }

        public  IUnit Common{
            get{
                return new second();
            }
        }

        public TimeUnitSys(){
            
        }
    }
}
