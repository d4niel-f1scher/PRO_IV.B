﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest_PRO
{
    class Oak:LeafTree
    {
        public void Grow() 
        {
            if (isDry)
            {
                throw new DryException();
            }
        }
    }
}
