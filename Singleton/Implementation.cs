namespace Singleton
{
    //public class Logger
    //{

    //    private static Logger? _instance;

    //    public static Logger Instance
    //    {
    //        get
    //        {
    //            if (_instance == null)
    //            {
    //                _instance = new Logger();
    //            }
    //            return _instance;
    //        }
    //    }

    //    //constructor
    //    protected Logger()
    //    {

    //    }
    

    //    //Method Log
    //    //Singleton Operation
    //    public void Log(string message)
    //    {
    //        Console.WriteLine($"Message to Log: {message}");
    //    }
    //}

    //Lazy Logger
    public class Logger
    {
        //Lazy<T>
        private static readonly  Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

  
        public static Logger Instance
        {
            get
            {
               return  _lazyLogger.Value;
            }
        }

        //constructor
        protected Logger()
        {

        }

        //Method Log
        //Singleton Operation
        public void Log(string message)
        {
            Console.WriteLine($"Message to Log: {message}");
        }
    }
}
