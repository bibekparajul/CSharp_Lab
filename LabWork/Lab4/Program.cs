

namespace Lab4
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Accessors");
            Distance D = new Distance();
            Time T = new Time() { 
                Sec = 86400 
            };
            
            Console.WriteLine($"distance cm={D.Cm}, m={D.M}, km={D.Km} ");
            Console.WriteLine($"time sec={T.Sec}, min={T.Min}, hr={T.Hr}");
            D.Cm = 90000;

            //Not possible to change time
            Console.WriteLine($"the time remains same ");
            Console.WriteLine($"time sec={T.Sec}, min={T.Min}, Hr={T.Hr}");
            Console.WriteLine($"distance cm={D.Cm}, m={D.M}, km={D.Km}");

        }
    }
    public class Distance
    {
        private decimal _Cm;
        public decimal Cm {
            get
            {
                return _Cm;
            }
            set {
                _Cm = value;
            }
        }
        public decimal M
        {
            get
            {
                return _Cm / 100;
            }
            set
            {
                _Cm = value * 100; } }
        public decimal Km 
        { 
            get
            {
                return M / 1000;
            } 
            set 
            {
                M = value * 1000; }
        }
    }

    public class Time
    {
        private decimal _Sec;
        public decimal Sec { get { return _Sec; } init { _Sec = value; } }
        public decimal Min { get { return _Sec / 60; } }
        public decimal Hr { get { return Min / 60; } }
    
    }

}