namespace CalculateDemo
{
    abstract class Operator
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public abstract int Calc();
    }
        class AddOperator : Operator
    {
        public override int Calc()
        {
            return Left + Right;
        }
    }
    class SubOperator : Operator
    {
        public override int Calc()
        {
            return Left - Right;
        }
    }
    class MulOperator : Operator
    {
        public override int Calc()
        {
            return Left * Right;
        }
    }
    class DivOperrator : Operator
    {
        public override int Calc()
        {
            return Left / Right;
        }
    }
}