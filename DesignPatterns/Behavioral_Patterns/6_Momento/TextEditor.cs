using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._6_Momento
{
    public class TextEditor
    {
        private string content = "";

        public void Write(string text)
        {
            content += text;
        }

        public void ShowContent()
        {
            Console.WriteLine("Current Content: " + content);
        }

        public Memento CreateMemento()
        {
            return new Memento(content);
        }

        public void Restore(Memento memento)
        {
            content = memento.GetSavedContent();
        }
    }
}
  
