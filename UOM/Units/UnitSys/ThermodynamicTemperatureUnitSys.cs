using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class ThermodynamicTemperatureUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("THermodynamicTemperature");
            }
        }

        public IUnit k{
            get{
                return new kelvin();
            }
        }

        public IUnit Primary{
            get{
                return new kelvin();
            }
        }

        public IUnit Common{
            get{
                return new kelvin();
            }
        }

    }
}
