using System

class Program_3_19{
    static void Main(string[] args){
                //...
    }

    public struct Point{
        private double _x;
        private double _y;

        public Point(double x, double y){
            _x = x;
            _y = y;
        }
        public double X => _x;
        public double Y => _y;
    }
}