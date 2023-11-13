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

        [PluginConfig]
        public Config Config;

        [PluginEntryPoint("Always_3114", "1.0.0", "Plugin that forces a 3114 in a game if there isn't one already", "linktheking")]
        public void Init()
        {
            Log.Info("Hello World");
        }

    }
}