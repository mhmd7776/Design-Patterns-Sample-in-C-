﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public interface ICompressor
    {
        void Compress(string fileName);
    }
}
