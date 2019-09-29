using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    class InvalidSongNameException : Exception
    {
        public InvalidSongNameException()
        {
        }

        public InvalidSongNameException(string message)
            : base(message)
        {
        }

        public InvalidSongNameException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
