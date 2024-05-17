using DesignPatterns.Behavioral_Patterns._2_Command;
using DesignPatterns.Behavioral_Patterns._5_Mediator.Colleagure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._5_Mediator.Interfaces
{
    public interface IChatRoomMediator
    {
        void SendMessage(string message, MedaitorUser user);
        void RegisterUser(MedaitorUser user);
    }
}
