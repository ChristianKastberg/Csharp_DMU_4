using System;

namespace CollectionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.ReadKey();
        }
    }
    struct Time
    {
        private int _secondsSinceMidnight;
        private int _maxSeconds;
        public int Seconds
        {
            set
            {
                int second = value;
            }
            get { return _secondsSinceMidnight; }
        }
        public int Minutes {
            set
            {
                int minute = value;

            }
            get {return _secondsSinceMidnight; }
        }

        public int Hour
        {
            set
            {
                int hour = value;
                int temp = _secondsSinceMidnight % 3600;
                _secondsSinceMidnight = (temp + hour * 3600) % _maxSeconds;
            }
            get { return _secondsSinceMidnight / 3600; }
        }

    }
}
