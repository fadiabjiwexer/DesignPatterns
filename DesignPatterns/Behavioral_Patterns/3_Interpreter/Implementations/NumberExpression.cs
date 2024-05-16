using DesignPatterns.Behavioral_Patterns._3_Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._3_Interpreter.Implementations
{
    // TerminalExpression
    public class NumberExpression : IExpression
    {
        private int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }
}
