using AltV.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkVServer
{
    class Server : Resource
    {
        public override void OnStart()
        {
            Alt.Log("Server wurde gestartet !");
        }

        public override void OnStop()
        {
            Alt.Log("Server wurde gestoppt !");
        }
    }
}
