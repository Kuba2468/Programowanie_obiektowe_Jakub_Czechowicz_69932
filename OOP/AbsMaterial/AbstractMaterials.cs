﻿using OOP.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.AbsMaterial
{
    abstract class AbstractMaterial : Construction
    {
        protected double MaterialCost;
        public abstract double CalculateMaterialCost();
    }
}
