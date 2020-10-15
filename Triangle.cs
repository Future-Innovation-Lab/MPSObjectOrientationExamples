namespace ObjectOrientation
{
    public class Triangle : Shape
    {
        private int _height;
        private int _breadth;

        public Triangle(int height=0,int breadth=0)
        {
            _height = height;
            _breadth = breadth;
        }

        public override double GetArea()
        {
            return 0.5 * _breadth * _height;
        }
    }
}