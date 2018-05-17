using System;
using UOM.Units;
using UOM.Units.UnitSys;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class IdentityUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Identity");
            }
        }
        public  IUnit k{
            get{
                return new one();
            }
        }
        public  IUnit Primary{
            get{
                return new one();
            }
        }

        public  IUnit Common{
            get{
                return new one();
            }
        }
    }
}
