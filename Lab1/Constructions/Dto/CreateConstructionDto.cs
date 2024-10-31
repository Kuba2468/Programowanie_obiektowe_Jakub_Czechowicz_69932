using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Dto.CreateConstructionDto
{
    internal class CreateConstructionDto
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { get; set; }
    }
}
