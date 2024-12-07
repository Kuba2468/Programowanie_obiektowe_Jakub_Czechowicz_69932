using OOP.Constructions.DTO;
using OOPLab2.AbsComBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.ComBuild
{
    internal class CommercialBuilding : AbstractCommercialBuilding
    {
        public CommercialBuilding(CreateConstructionDTO construction, string businessType) : base(construction, businessType)
        {
        }
        public override void OpenBusiness()
        {
            Console.WriteLine($"The {BusinessType} business is open in the conmmercial building!");
        }

    }
}
