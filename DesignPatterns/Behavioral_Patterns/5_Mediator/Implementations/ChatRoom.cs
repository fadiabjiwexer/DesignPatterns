using DesignPatterns.Behavioral_Patterns._2_Command;
using DesignPatterns.Behavioral_Patterns._5_Mediator.Colleagure;
using DesignPatterns.Behavioral_Patterns._5_Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._5_Mediator.Implementations
{
    public class ChatRoom : IChatRoomMediator
    {
        private List<MedaitorUser> _users = new List<MedaitorUser>();

        public void RegisterUser(MedaitorUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, MedaitorUser user)
        {
            foreach (var u in _users)
            {
                // Don't notify the sender.
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
