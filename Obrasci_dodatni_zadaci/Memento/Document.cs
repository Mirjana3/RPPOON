using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class Document
    {
        public string Content { get; set; }
        public Document(string content)
        {
            Content = content;
        }
        public DocumentTrace CreateTrace()
        {
            return new DocumentTrace(Content);
        }
        public void RestoreFromTrace(DocumentTrace trace)
        {
            Content = trace.GetSavedContent();
        }
        public void Print()
        {
            Console.WriteLine($"Document content: {Content}");
        }

    }
}
