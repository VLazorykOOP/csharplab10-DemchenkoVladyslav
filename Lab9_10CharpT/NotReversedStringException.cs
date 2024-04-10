using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class NotReversedStringException : Exception
    {
        public NotReversedStringException() : base("This string is not reversed") { }
        public NotReversedStringException(string message) : base(message) { }
    }
}
