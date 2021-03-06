﻿using StreamExtended;

namespace Titanium.Web.Proxy.Http
{
    /// <summary>
    /// The tcp tunnel Connect request.
    /// </summary>
    public class ConnectRequest : Request
    {
        public ConnectRequest()
        {
            Method = "CONNECT";
        }

        public ClientHelloInfo ClientHelloInfo { get; set; }
    }
}
