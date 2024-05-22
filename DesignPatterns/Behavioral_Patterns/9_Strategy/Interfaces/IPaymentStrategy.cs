using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._9_Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}
