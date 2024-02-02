using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class DocumentMemento
    {
        private readonly DocumentTrace trace;

        public DocumentMemento(DocumentTrace trace)
        {
            this.trace = trace;
        }

        public DocumentTrace GetTrace()
        {
            return trace;
        }
    }
}
