namespace Delegates
{
    public delegate void HelloDelegate(string str);
    public class AnonymousDelegate
    {
        public static void Main(string[] args)
        {
            HelloDelegate obj = delegate (string str)
            {
                Console.WriteLine("Hello " + str);
            };
            obj("Sumit");
        }

    }
}
