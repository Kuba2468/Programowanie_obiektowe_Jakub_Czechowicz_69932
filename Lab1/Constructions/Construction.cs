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

        }
        public Construction(float height, float width, int entrances, int humancapacity, string buildmaterial)
        {
            Height = height;
            Width = width;
            Entrances =
            HumanCapacity = humancapacity;
            BuildMaterial = buildmaterial;

        }


        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }+
        private string _buildMaterial { get; set; }

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
