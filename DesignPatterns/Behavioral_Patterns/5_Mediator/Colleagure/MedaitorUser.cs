using DesignPatterns.Behavioral_Patterns._5_Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._5_Mediator.Colleagure
{
    public class MedaitorUser
    {
        private IChatRoomMediator _chatRoom;
        public string Name { get; private set; }

        public MedaitorUser(IChatRoomMediator chatRoom, string name)
        {
            _chatRoom = chatRoom;
            Name = name;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _chatRoom.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} receives: {message}");
        }
    }
}
