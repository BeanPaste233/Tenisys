﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenisys.Commands
{
    interface ICommand
    {
        string Permission { get; }
    }
}