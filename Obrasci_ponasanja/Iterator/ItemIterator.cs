using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_ponasanja
{
    public class ItemIterator : IIterator
    {
        ItemCollection collection;
        int current;

        public ItemIterator(ItemCollection collection)
        {
            this.collection = collection;
            current = 0;
        }
        public Item GetNext()
        {
            Item item = collection.GetItem(current);
            current++;
            return item;
        }

        public bool HasNext()
        {
            return current >= collection.Count();
        }
    }
}
