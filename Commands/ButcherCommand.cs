using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace Tenisys.Commands
{
    public class ButcherCommand : ModCommand,ICommand
    {
        public override string Command => "butcher";

        public override CommandType Type =>CommandType.Chat;

        public override string Usage => "/butcher ";

        public override string Description => "run this command will help you butcher all monsters";

        public string Permission =>"tenisys.world.butcher";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            var plr = Tenisys.Players[caller.Player.whoAmI];
            if (plr==null)
            {
                return;
            }
            if (plr.HasPermission(Permission))
            {
                int count = 0;
                for (int i = 0; i < Terraria.Main.npc.Length; i++)
                {
                    var npc = Terraria.Main.npc[i];
                    if (npc.friendly == false)
                    {
                        npc.StrikeNPC(npc.lifeMax, 0, 0);
                        count++;
                    }
                }
                plr.SendSuccessfulMessage($"你成功清除了 {count} 个NPC");
            }
            else {
                plr.SendInfoMessage("你没有权限使用这个指令");
            }
        }
    }
}
