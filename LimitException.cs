using System;

namespace TechnicalTest
{
    class LimitException : Exception
    {
        public LimitException(string msg) : base(msg)
        {

            Console.WriteLine(msg);
            return;

        }

    }
}
