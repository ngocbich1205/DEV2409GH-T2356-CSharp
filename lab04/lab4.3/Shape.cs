﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
    abstract class Shape
    {
        protected float radius, length, width;
        public abstract float Area();
        public abstract float Circumference();
    }
}
