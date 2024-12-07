using OOP.Constructions.DTO;
using OOP.Constructions.Models;
using OOPLab2.AbsMaterial;
using OOPLab2.Interfaces;
using OOPLab2.MaterialClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructions
{
    internal class Construction: ISquareCost, IConstructionInfo
    {
        public Construction()
        {
            Height = 23;
            Width = 45;
            Entrances = 4;
            HumanCapacity = 12;
            BuildMaterial = BuildMaterialEnum.Wood;
            Roofing = "Asbestos";
        }
        public Construction(CreateConstructionDTO construction)
        {
            Height = construction.Height;
            Width = construction.Width;
            Entrances = construction.Entrances;
            HumanCapacity = 2;
            BuildMaterial = construction.BuildMaterial;
        }
        public Construction(float height, float width, int entrances, int humancapacity, BuildMaterialEnum buildmaterial, string roofing)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humancapacity;
            BuildMaterial = buildmaterial;
            Roofing = roofing;

        }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string Roofing { get; set; }
        private BuildMaterialEnum _buildMaterial { get; set; }
        public BuildMaterialEnum BuildMaterial

        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                //if (value == null)
                //{
                //    throw new ArgumentNullException("value cannot be null");
                //}
                _buildMaterial = value;
            }

        }
        public float SquareCost
        {
            get
            {
                if (BuildMaterial == BuildMaterialEnum.Concrete)
                {
                    return 0.87f * Height * Width * 0.9f;
                }

                else if (BuildMaterial == BuildMaterialEnum.Brik)
                {
                    return 0.8f * Height * Width * 0.9f;
                }
                return 0.78f * Height * Width * 0.9f;

            }
        }

        public double CalculateSquareCost()
        {
            return SquareCost;
        }
        public void DisplayCostDetails() 
        {
            Console.WriteLine($"Square cost details for thebuilding: ");
            Console.WriteLine($"Height: {Height}, Width: {Width},Entrances: { Entrances}, Human Capacity: { HumanCapacity}, BuildMaterial: { BuildMaterial}");
            Console.WriteLine($"Square Cost: {CalculateSquareCost()}");
        }
        public void DisplayConstructionInfo()
        {
            Console.WriteLine($"Square cost details for thebuilding: ");
            Console.WriteLine($"Height: {Height}, Width: {Width},Entrances: {Entrances}, Human Capacity: {HumanCapacity}, BuildMaterial: {BuildMaterial}");
            Console.WriteLine($"Square Cost: {CalculateSquareCost()}");
        }
        private AbstractMaterial _material { get; set; }
        private void InitializeMaterial()
        {
            switch (_buildMaterial)
            {
                case BuildMaterialEnum.Brik:
                    _material = new BrikMaterial();
                    break;
                case BuildMaterialEnum.Concrete:
                    _material = new ConcreteMaterial();
                    break;
                case BuildMaterialEnum.Wood:
                    _material = new WoodMaterial();
                    break;
                default:
                    throw new ArgumentException("Invalid build material type");
            }
        }
        public double GetSquareCost()
        {
            InitializeMaterial();
            if (BuildMaterial == BuildMaterialEnum.Brik)
            {
                return Width * Height * 0.9 *
                _material.CalculateMaterialCost();
            }
            if (BuildMaterial == BuildMaterialEnum.Concrete)
            {
                return Width * Height * 0.9 *
                _material.CalculateMaterialCost();
            }
            if (BuildMaterial == BuildMaterialEnum.Wood)
            {
                return Width * Height * 0.9 *
                _material.CalculateMaterialCost();
            }
            return 0;
        }
    }
}
