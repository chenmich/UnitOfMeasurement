namespace UOM.Quantities
{
    internal struct TypeExpression{
        internal IQuantityType left{
            get; private set;
        }
        internal IQuantityType right{
            get; private set;
        }
        
        internal TypeOperator Operator{
            get; private set;
        }
    }
}
