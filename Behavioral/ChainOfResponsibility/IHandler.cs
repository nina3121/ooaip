﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        object Handle(object handler);

        IHandler SetHandler(IHandler handler);
    }
}