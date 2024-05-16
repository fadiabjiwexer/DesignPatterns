using DesignPatterns.Behavioral_Patterns._3_Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._3_Interpreter.Implementations
{
    // NonTerminalExpression
    public class AdditionExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public AdditionExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() + _right.Interpret();
        }
    }
}
