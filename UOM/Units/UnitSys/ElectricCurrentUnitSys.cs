using System;
using UOM.Quantities;
namespace UOM.Units.UnitSys
{
    public class ElectricCurrentUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("ElectricCurrentUnitSys");
            }
        }

        public IUnit k{
            get{
                return new kampere();
            }
        }

        public IUnit Primary{
            get{
                return new ampere();
            }
        }

        public IUnit Common{
            get{
                return new mampere();
            }
        }
    }
}
