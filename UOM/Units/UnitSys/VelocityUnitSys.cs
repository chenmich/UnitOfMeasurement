using System;
using UOM.Units;
using UOM.Quantities;


namespace UOM.Units.UnitSys
{
    public class VelocityUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Velocity");
            }
        }
        public  IUnit k{
            get{
                return new kmeterpersecond();
            }
        }

        public  IUnit Primary{
            get{
                return new meterpersecond();
            }
        }

        public  IUnit Common{
            get{
                return new kmeterpersecond();
            }
        }

        public VelocityUnitSys(){
            
        }

    }
}
