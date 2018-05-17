using System;
using UOM.Units;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class VolumnUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Volumn");
            }
        }

        public IUnit k{
            get{
                return new kcubicmeter();
            }
        }

        public IUnit Primary{
            get{
                return new cubicmeter();
            }
        }

        public IUnit Common{
            get{
                return new cubicmeter();
            }
        }
    }
}
