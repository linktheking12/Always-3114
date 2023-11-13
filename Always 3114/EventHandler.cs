using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;

namespace Always_3114
{

    public class EventHandler
    {
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
