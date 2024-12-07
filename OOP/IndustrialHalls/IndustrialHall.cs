using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Constructions;
using OOP.Constructions.Models;

namespace OOP.IndustrialHall
{
    internal class IndustrialHall : Construction
    {
        public IndustrialHall() : base(23.0f, 45.0f, 4, 4, BuildMaterialEnum.Wood, "Material")
        {
            Console.WriteLine("Initialization of industrial hall");
        }
    }
}