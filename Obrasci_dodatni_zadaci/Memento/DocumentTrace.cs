using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class DocumentTrace
    {
        private readonly string content;
        public DocumentTrace(string content)
        {
            this.content = content;
        }
        public string GetSavedContent()
        {
            return content;
        }

    }
}
