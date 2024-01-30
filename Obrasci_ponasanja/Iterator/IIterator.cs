using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_ponasanja
{
    public interface IIterator
    {
        Item GetNext();
        bool HasNext();
    }
}
