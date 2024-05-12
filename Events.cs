using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkVServer
{
    public class Events : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void OnPlayerConnect(IPlayer iplayer, String reason)
        {
            iplayer.Spawn(new AltV.Net.Data.Position(-427, 1115, 326), 0);
            iplayer.Model = (uint)PedModel.Business01AMM;
            Alt.Log($"Spieler {iplayer.Name} hat den Server betreten!");
        }

        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public void OnPlayerDisconnect(IPlayer iplayer, string reason)
        {
            Alt.Log($"Spieler {iplayer.Name} hat den Server verlassen!");
        }
    }
}
