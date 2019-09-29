using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException()
        {
        }

        public InvalidSongSecondsException(string message)
            : base(message)
        {
        }

        public InvalidSongSecondsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
