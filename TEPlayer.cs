using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Tenisys
{
    public class TEPlayer:ModPlayer
    {
        public int Index { get; set; }
        public int AccountID { get; set; }
        public bool IsLoggedIn { get; set; }
        public string Password { get; set; }
        public List<string> Permission { get; }
        public Terraria.Player TPlayer { get; set; }
        public TEPlayer(int index) 
        {
            TPlayer = Terraria.Main.player[index];
            Index = index;
            IsLoggedIn = false;
        }
        public void SendMessage(string text,Color color)
        {
            NetMessage.SendChatMessageToClient(NetworkText.FromLiteral(text),color,Index);
        }
        public void SendInfoMessage(string text) 
        {
            SendMessage(text,Color.Moccasin);
        }
        public void SendErrorMessage(string text) 
        {
            SendMessage(text,Color.Crimson);
        }
        public void SendSuccessfulMessage(string text) 
        {
            SendMessage(text,Color.MediumAquamarine);
        }
        public void SetTeam(Enum.TeamEnum teamType) 
        {
            TPlayer.team = (int)teamType;
            NetMessage.SendData(45, -1, -1, NetworkText.Empty, Index);
        }
        public void SendData(int msgID,int remoteClient,int ignoreClient,string networkText,int number1,float number2) { }
        public override void PostUpdate()
        {
            
        }
        public override void OnEnterWorld(Player player)
        {
            
        }
        public bool HasPermission(string perm)
        {
            if (Permission.Contains(perm))
            {
                return true;
            }
            return false;
        }
    }
}
