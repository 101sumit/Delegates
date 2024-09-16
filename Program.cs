namespace Delegates
{
    public delegate void NotificationHandler(string msg);

    public class Program
    {
        public static void EmailNotification(string msg)
        {
            Console.WriteLine("Send Email " + msg);
        }
        public static void SmsNotification(string msg)
        {
            Console.WriteLine("Send SMS " + msg);
        }
        public static void ProcecessHandler(NotificationHandler notification, string msg)
        {
            notification(msg);
        }
        
        public static void Main(string[] args)
        {
            NotificationHandler email = new NotificationHandler(EmailNotification);
            NotificationHandler sms = new NotificationHandler(SmsNotification);
            ProcecessHandler(email, "New Email");
            ProcecessHandler(sms, "New Sms");
        }
    }
}