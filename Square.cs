namespace ObjectOrientation
{
    public class Square : Shape
    {
        private int _side;

        public Square(int side=0)
        {
            _side = side;
        }

        public override double GetArea()
        {
            return (_side * _side);
        }
    }

}