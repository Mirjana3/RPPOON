﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_ponasanja
{
    interface ICollection
    {
        IIterator CreateIterator();
    }
}
