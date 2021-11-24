using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Tenisys.Commands
{
    public class RegisterCommand : ModCommand,ICommand
    {
        public override string Command => "register";

        public override CommandType Type => CommandType.Chat;

        public override string Usage => "/register [密码] [再次确认]";

        public override string Description => "A register command";

        public string Permission=>"tenisys.user.register" ;

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            if (args.Length<1)
            {
                
                return;
            }
            string password = args[0];
            string password_again = args[1];

        }
    }
}
