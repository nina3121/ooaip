﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public interface IMemento
    {
        string GetDate();

        string GetState();
    }
}