using OOP.Constructions;
using OOP.Constructions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.AbsComBuild
{
    internal abstract class AbstractCommercialBuilding: Construction
    {
        protected AbstractCommercialBuilding(CreateConstructionDTO construction, string businessType) : base(construction)
        {
            BusinessType = businessType;
        }
        public string BusinessType { get; set; }
        public abstract void OpenBusiness();
    }
}
