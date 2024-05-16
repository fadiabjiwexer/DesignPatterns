using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._1_Chain_of_Responsibility
{

//    Let's say we have a system where we need to handle different types of requests
        //1 - A request for a discount.
        //2 - A request for a refund.
        //3 - A request for customer support.
        //Each of these requests needs to be handled differently.
    class Request
    {
        public string Type { get; }

        public Request(string type)
        {
            Type = type;
        }
    }
}
