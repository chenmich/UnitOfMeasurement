using System;
using UOM.Units;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class AreaUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Area");
            }
        }

        public IUnit k{
            get{
                return new ksquaremeter();
            }
        }

        public IUnit Primary{
            get{
                return new squaremeter();
            }
        }

        public IUnit Common{
            get{
                return new squaremeter();
            }
        }
    }
}
