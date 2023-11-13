using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Core.Interfaces;
using PluginAPI.Enums;
using PluginAPI.Events;
using System;


namespace Always_3114
{
    public class MainClass
    {

        [PluginEntryPoint("Always_3114", "1.0.0", "Plugin that forces a 3114 in a game if there isn't one already", "linktheking")]
            public void Init()
            {
                Log.Info("Hello World");
             }
        [PluginConfig]
        public Config Config;

        
        [PluginEvent(ServerEventType.RoundStart)]
        public void RoundStart()
        {
            System.Random random = new System.Random();
            bool NeedSpawn = true;
            do
            {
                string ran = (random.Next(1, Server.PlayerCount).ToString());
                if (Player.PlayersUserIds.ContainsKey(ran))
                {
                    Player temp = Player.Get(ran);
                    if (!temp.IsSCP)
                    {
                        Server.RunCommand("forceclass " + ran + ".scp3114 3");
                        NeedSpawn = false;
                    }
                }
            } while (NeedSpawn);

        }
    }
}