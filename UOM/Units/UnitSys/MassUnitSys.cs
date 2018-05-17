using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class MassUnitSys:IUnitSys
    {
        public IQuantityType QType{
            get{
                QuantityTypeService service = QuantityTypeService.getService();
                return service.getType("Mass");
            }
        }
        public  IUnit k{
            get{
                return new kilogram();
            }
        }

        public  IUnit Primary{
            get{
                return new kilogram();
            }
        }

        public  IUnit Common{
            get{
                return new kilogram();
            }
        }

        public MassUnitSys(){
            
        }
    }
}
