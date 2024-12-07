using OOPLab2.AbsMaterial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.MaterialClasses
{
    class BrikMaterial : AbstractMaterial
    {
        public BrikMaterial()
        {
            MaterialCost = 300;
        }
        public override double CalculateMaterialCost()
        {
            return MaterialCost;
        }
    }

}
