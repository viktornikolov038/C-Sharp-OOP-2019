using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    class InvalidSongMinutesException : Exception
    {
        public InvalidSongMinutesException()
        {
        }

        public InvalidSongMinutesException(string message)
            : base(message)
        {
        }

        public InvalidSongMinutesException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
