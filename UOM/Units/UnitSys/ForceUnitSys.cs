using System;
using UOM.Units;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class ForceUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Force");
            }
        }
        public  IUnit k{
            get{
                return new knewton();
            }
        }

        public  IUnit Primary{
            get{
                return new newton();
            }
        }

        public  IUnit Common{
            get{
                return new knewton();
            }
        }

        public ForceUnitSys(){
            
        }

    }
}
