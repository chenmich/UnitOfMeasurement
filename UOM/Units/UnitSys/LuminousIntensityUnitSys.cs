using System;
using UOM.Quantities;
namespace UOM.Units.UnitSys
{
    public class LuminousIntensityUnitSys:IUnitSys
    {
       public IQuantityType QType{
           get{
               QuantityTypeService service = QuantityTypeService.getService();
               return service.getType("LuminousIntensity");
           }
       }
       public IUnit k{
           get{
               return new kcandela();
           }
       }

       public IUnit Primary{
           get{
               return new candela();
           }
       }

       public IUnit Common{
           get{
               return new candela();
           }
       }
    }
}
