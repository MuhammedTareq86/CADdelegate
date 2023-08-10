namespace operatorOverloading
{
    public delegate void rectDelegate(double length, double width);
    public class rectangle
    {

        public void getArea(double length, double width)
        {
            Console.WriteLine($"Area of Rectangle =  { length } * { width } = { length * width }");
        }
        public void getPrimeter(double length, double width)
        {
            Console.WriteLine($"Primeter of Rectangle =  2 ( { length } + { width }) = { 2 * ( length + width ) }");
        }
    }
}
