using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class StressUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Stress");
            }
        }

        public IUnit k{
            get{
                return new kpascal();
            }
        }

        public IUnit Primary{
            get{
                return new pascal();
            }
        }

        public IUnit Common{
            get{
                return new Mpascal();
            }
        }
    }
}
