namespace Delegates
{
    public class MultiDelegate
    {
        public delegate void RectangleDelegate(int h, int w);
        public void Area(int h, int w)
        {
            Console.WriteLine("Area : " + h * w);
        }
        public void Redius(int h, int w)
        {
            Console.WriteLine("Redius : " + 2*(h + w));
        }
        public static void Main(string[] args)
        {
            MultiDelegate obj = new MultiDelegate();
            RectangleDelegate area = new RectangleDelegate(obj.Area);
            area += obj.Redius;
            area(4, 5);
        }
    }
}
