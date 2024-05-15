using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.Right.Interface;

namespace DesignPatterns.State.Right
{
    public class Canvas
    {
        private Tool currentTool;
        public Tool GetCurrentTool() { return currentTool; }
        public void SetCurrentTool(Tool currentTool) { this.currentTool = currentTool; }

        public void mouseDown()
        {
            currentTool.mousDown();
        }
        public void mouseUp()
        {
            currentTool.mousUp();
        }
    }
}
