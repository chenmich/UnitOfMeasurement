using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class AmountOfSubstanceUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("AmountOfSubstance");
            }
        }

        public IUnit k{
            get{
                return new kmole();
            }
        }

        public IUnit Primary{
            get{
                return new mole();
            }
        }

        public IUnit Common{
            get{
                return new mole();
            }
        }
    }
}
