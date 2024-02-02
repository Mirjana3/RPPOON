using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public static class KlijentskiKod
    {
        public static void Run()
        {
            Document document = new Document("Content");
            DocumentHistory history = new DocumentHistory();

            history.SaveVersion(document);

            document.Content = "Updated content";

            history.SaveVersion(document);

            document.Print();

            history.Undo(document);

            document.Print();
        }
    }
}
