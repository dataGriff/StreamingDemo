using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;

namespace FruitConsole
{
    public class StandardLog
    {
        public enum LogCode
        {
            Failure = 0,
            Success = 1
        }

        public string userName { get; private set; }

        public DateTime dtUtc { get; private set; }

        public DateTime dt { get; private set; }

        public string hostName { get; private set; }

        public string localIP { get; private set; }

        public LogCode logCode { get; private set; }

        public StandardLog(LogCode logCode)
        {
          this.userName = Environment.UserName;
          this.dtUtc = DateTime.UtcNow;
          this.dt = DateTime.Now;
          this.hostName = Dns.GetHostName();
          this.localIP = Dns.GetHostEntry(hostName).AddressList.GetValue(0).ToString();
          this.logCode = logCode;
        }
    }
}
