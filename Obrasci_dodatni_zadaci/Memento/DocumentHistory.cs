using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class DocumentHistory
    {
        private readonly Stack<DocumentMemento> history = new Stack<DocumentMemento>();
        public void SaveVersion(Document document)
        {
            history.Push(new DocumentMemento(document.CreateTrace()));
        }
        public void Undo(Document document)
        {
            if (history.Count > 0)
            {
                var trace = history.Pop();
                document.RestoreFromTrace(trace.GetTrace());
            }
            else
            {
                Console.WriteLine("No more versions to undo.");
            }
        }

    }
}
