using System;
using System.Collections.Generic;
using System.Text;

namespace FruitConsole
{
    class ColourException : Exception
    {
        public string colour;

        public StandardLog standardLog { get; private set; }

        public ColourException(string message, string colour) : base(message)
        {
            this.colour = colour;
            standardLog = new StandardLog(StandardLog.LogCode.Failure);
        }
    }
}
