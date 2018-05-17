using System;
using UOM.Quantities;


namespace UOM.Units.UnitSys
{
    public  abstract class UnitSys:IUnitSys
    {
        public virtual IQuantityType QType{
            get; 
        }
        public virtual IUnit Primary{
            get;
        }
        public virtual IUnit Common{
            get;
        }
        public virtual IUnit k{
            get;
        }
        public UnitSys(string qTypeName){
            QuantityTypeService service = QuantityTypeService.getService();
            QType = service.getType(qTypeName);
        }
        internal UnitSys(){}
    }
}
