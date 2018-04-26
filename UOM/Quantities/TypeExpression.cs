namespace UOM.Quantities
{
    public struct TypeExpression{
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
        public override int GetHashCode(){
            return Left.GetHashCode() ^ Operator.GetHashCode() ^ Right.GetHashCode();
        }

        public override string ToString(){
            return string.Format("left: {0}   op: {1}    right: {2}", 
                Left.Id.Name, Operator.ToString(), Right.Id.Name);
        } 
    }
}
