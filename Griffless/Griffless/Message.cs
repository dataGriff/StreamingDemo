using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;

namespace FruitConsole
{
    public class Message
    {

        public string userName { get; private set; }

        public DateTime dtUtc { get; private set; }

        public DateTime dt { get; private set; }

        public string hostName { get; private set; }

        public string localIP { get; private set; }

        public Message()
        {
          this.userName = Environment.UserName;
          this.dtUtc = DateTime.UtcNow;
          this.dt = DateTime.Now;
          this.hostName = Dns.GetHostName();
          this.localIP = Dns.GetHostEntry(hostName).AddressList.GetValue(0).ToString();
        }
    }
}
