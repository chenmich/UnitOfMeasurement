namespace UOM.Quantities
{
    internal struct TypeExpression{
        internal IQuantityType Left{
            get;  set;
        }
        internal IQuantityType Right{
            get;  set;
        }
        
        internal TypeOperator Operator{
            get; set;
        }
        internal TypeExpression(IQuantityType left, IQuantityType right, TypeOperator op){
            Left = left;
            Right = right;
            Operator = op;
        }
    }
}
