using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    class InvalidSongLengthException : Exception
    {
        public InvalidSongLengthException()
        {
        }

        public InvalidSongLengthException(string message)
            : base(message)
        {
        }

        public InvalidSongLengthException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
