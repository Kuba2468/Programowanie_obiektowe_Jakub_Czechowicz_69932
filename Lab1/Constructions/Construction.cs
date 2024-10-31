using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Constructions
{
    internal class Construction
    {
        public Construction()
        {
            Height 23;
            Width = 43;
            Entrances = 3;
            HumanCapacity = 2;
            BuildMaterial = "Material";
        }
        public Construction(CreateConstructionDto construction)
        {
            Height = construction.height;
            Width = construction.width;
            Entrances = construction.entrances;
            HumanCapacity = construction.humancapacity;
            BuildMaterial = construction.buildmaterial;
        }
            public Construction(float height, float width, int entrances, int humancapacity, string buildmaterial)
        {
            Height = height;
            Width = width;
            Entrances =
            HumanCapacity = humancapacity;
            BuildMaterial = buildmaterial;

        }


            CreateConstructionDto

        public string BuildMaterial {
            get
            {
                return _buildMaterial;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value can not be null");
                }
                _buildMaterial = value + "test";
            }
        }

    }

}
