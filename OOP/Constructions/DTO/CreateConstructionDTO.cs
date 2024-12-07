using OOP.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructions.DTO
{
    internal class CreateConstructionDTO
    {
        public CreateConstructionDTO()
        {
            Height = 54;
            Width = 32;
            Entrances = 6;
            BuildMaterial = BuildMaterialEnum.Wood;
        }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public BuildMaterialEnum BuildMaterial { get; set; }
    }
}