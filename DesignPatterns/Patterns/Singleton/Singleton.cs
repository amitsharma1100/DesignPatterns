using System;

namespace DesignPatterns.Patterns.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private Theatre theatre = new Theatre();
        private static readonly Object padLock = new Object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            lock(padLock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

        public string AlloteSeat(int row, int column)
        {
            if (row > 20 || row < 0|| column > 20 || column < 0 || theatre.seats[row, column] == 1)
            {
                return "Not Alloted";
            }

            theatre.seats[row, column] = 1;
            return "Alloted";
        }
    }
}
